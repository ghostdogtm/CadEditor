using CadEditor;
using PluginMapEditor;
using System.Collections.Generic;
using System;
//css_include Settings_CapcomBase.cs;
public class Data:CapcomBase
{
  public string[] getPluginNames() 
  {
    return new string[] 
    {
      "PluginMapEditor.dll",
      "PluginChrView.dll",
      "PluginEditLayout.dll",
    };
  }
  public bool isShowScrollsInLayout() { return false; }
  
  public OffsetRec getPalOffset()       { return new OffsetRec(0x3E2F, 12   , 16);     }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0x4D10 , 7   , 0xD00);  }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0x4D10 , 7   , 0xD00);  }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x7310 , 3   , 0x4000); }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x1008A , 5  , 0x440);  }
  public OffsetRec getScreensOffset()   { return new OffsetRec(0x11d5a, 300 , 0x40);   }
  public IList<LevelRec> getLevelRecs() { return levelRecsDt2; }
  public string[] getBlockTypeNames()   { return objTypesDt2;  }
  
  public override GetVideoPageAddrFunc getVideoPageAddrFunc() { return getDuckTalesVideoAddress; }
  public override GetVideoChunkFunc    getVideoChunkFunc()    { return getDuckTalesVideoChunk;   }
  public override SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  public override GetBlocksFunc        getBlocksFunc()        { return getBlocksDt2;}
  public override SetBlocksFunc        setBlocksFunc()        { return setBlocksDt2;}
  public override GetBigBlocksFunc     getBigBlocksFunc()     { return getBigBlocksDt2;}
  public override SetBigBlocksFunc     setBigBlocksFunc()     { return setBigBlocksDt2;}
  public GetObjectsFunc getObjectsFunc() { return getObjectsDt2; }
  public SetObjectsFunc setObjectsFunc() { return null; }
  
  public IList<LevelRec> levelRecsDt2 = new List<LevelRec>() 
  {
    new LevelRec(0x19488, 0xFF, 8, 6, 0x11C3A),
    new LevelRec(0x195A7, 0xFF, 8, 6, 0x11C6A),
    new LevelRec(0x196E7, 0xFF, 8, 6, 0x11C9A),
    new LevelRec(0x19830, 0xFF, 8, 6, 0x11CCA),
    new LevelRec(0x19970, 0xFF, 8, 6, 0x11CFA),
    new LevelRec(0x19A87, 0xFF, 8, 6, 0x11D2A),
    new LevelRec(0x19B9E, 0xFF, 8, 6, 0x11C6A),
  };
  
  public GroupRec[] getGroups()
  {
    return new GroupRec[] { 
      new GroupRec("Niagara"         , 0,0,0,0, 0x01),
      new GroupRec("Bermuda"         , 1,0,1,2, 0x20),
      new GroupRec("Egypt"           , 2,1,2,4, 0x41),
      new GroupRec("Mu"              , 3,1,3,6, 0x5F),
      new GroupRec("Scotland"        , 4,2,4,8, 0x81),
      new GroupRec("Scotland 2"      , 4,2,4,8, 0x9E),
    };
  }
  
  string[] objTypesDt2 = new[] {
    "no","no","no","no","no","no","no","no",
    "no","no","no","no","no","no","no","no"
  };
  
  public MapInfo[] getMapsInfo() { return mapsDt2; }
  public LoadMapFunc getLoadMapFunc() { return MapUtils.loadMapDt2; }
  public SaveMapFunc getSaveMapFunc() { return MapUtils.saveMapDt2; }

  MapInfo[] mapsDt2 = new MapInfo[]
  { 
      new MapInfo(){   dataAddr = 0xF200, palAddr = 0x3DCF, videoNo = 6 }
  };

  
  //--------------------------------------------------------------------------------------------
  //duck tales specific
  public int getDuckTalesVideoAddress(int id)
  {
    return -1;
  }
  
  public byte[] getDuckTalesVideoChunk(int videoPageId)
  {
    if (videoPageId < 0x96)
    {
        return Utils.readVideoBankFromFile("videoBack_DT2.bin", videoPageId);
    }
    else
    {
        return Utils.readVideoBankFromFile("videoMap_DT2.bin", 0x90);
    }
  }
  
  public int getBigBlocksCountForLevel(int levelNo)
  {
    int[] bigBlocksCount = {207,195,169,176,209,209};
    return bigBlocksCount[levelNo];
  }
  
  public int[] getBigBlocksPtrsForLevel(int levelNo)
  {
    int[][] levelPointers = { 
     new int[]{0x10D4A, 0x10E19, 0x10EE8, 0x10FB7},  //ptrs for level 1
     new int[]{0x11086, 0x11149, 0x1120C, 0x112CF},  //ptrs for level 2
     new int[]{0x11392, 0x1143B, 0x114E4, 0x1158D},  //ptrs for level 3
     new int[]{0x11636, 0x116E6, 0x11796, 0x11846},  //ptrs for level 4
     new int[]{0x118F6, 0x119C7, 0x11A98, 0x11B69},  //ptrs for level 5
     new int[]{0x118F6, 0x119C7, 0x11A98, 0x11B69}   //ptrs for level 6 (same as 5)
    };
    return levelPointers[levelNo];
  }
  
  public BigBlock[] getBigBlocksDt2(int bigTileIndex)
  {
    int[] addrPointers = getBigBlocksPtrsForLevel(bigTileIndex);
    int blocksCount = getBigBlocksCountForLevel(bigTileIndex);
    byte[] bigBlockIndexes = new byte[getBigBlocksCount()*4];
    byte[] tempIndexes = Utils.readDataFromUnalignedArrays(Globals.romdata, addrPointers[0], addrPointers[1], addrPointers[2], addrPointers[3], blocksCount);
    Array.Copy(tempIndexes, bigBlockIndexes, blocksCount*4); 
    return Utils.unlinearizeBigBlocks<BigBlock>(bigBlockIndexes, 2, 2);
  }
  
  public void setBigBlocksDt2(int bigTileIndex, BigBlock[] bigBlocks)
  {
    int[] addrPointers = getBigBlocksPtrsForLevel(bigTileIndex);
    int blocksCount = getBigBlocksCountForLevel(bigTileIndex);
    var data = Utils.linearizeBigBlocks(bigBlocks);
    Utils.writeDataToUnalignedArrays(data, Globals.romdata, addrPointers[0], addrPointers[1], addrPointers[2], addrPointers[3], blocksCount); 
  }
  
  public List<ObjectList> getObjectsDt2(int levelNo)
  {
    LevelRec lr = ConfigScript.getLevelRec(levelNo);
    int objCount = lr.objCount, addr = lr.objectsBeginAddr;
    var objects = new List<ObjectRec>();

    int objectsReaded = 0;
    int currentHeight = 0;
    while (objectsReaded < objCount)
    {
        byte command = Globals.romdata[addr];
        if (command == 0xFF)
        {
            currentHeight = Globals.romdata[addr + 1];
            if (currentHeight == 0xFF)
                break;
            addr += 2;
        }
        else
        {
            byte v = Globals.romdata[addr + 2];
            byte xbyte = Globals.romdata[addr + 0];
            byte ybyte = Globals.romdata[addr + 1];
            byte sx = (byte)(xbyte >> 5);
            byte x = (byte)((xbyte & 0x1F) << 3);
            byte sy = (byte)currentHeight;
            byte y = ybyte;
            var obj = new ObjectRec(v, sx, sy, x, y);
            objects.Add(obj);
            objectsReaded++;
            addr += 3;
        }
    }
    return new List<ObjectList> { new ObjectList { objects = objects, name = "Objects" } };
  }
  
  /*public bool setObjectsDt2(int levelNo, List<ObjectList> objects)
  {
    //todo : add save for duck tales 2
    return true;
  }*/
  
  public class Dt2ObjRec : ObjRec
  {
    public Dt2ObjRec(ObjRec b, int _index)
        :base(b)
    {
        index = _index;
    }
    
    public override int getType()
    {
        return index < 0xA0 ? 0 : 5;
    }
    
    int index;
  }
  
  public ObjRec[] getBlocksDt2(int blockIndex)
  {
    ObjRec[] blocks = Utils.readBlocksFromAlignedArrays(Globals.romdata, ConfigScript.getTilesAddr(blockIndex), getBlocksCount());
    //decode typeColor
    int palInfoCount = getBlocksCount()/4;
    var palInfo = new byte[palInfoCount];
    for (int i = 0; i < palInfoCount; i++)
    {
        palInfo[i] = (byte)blocks[i].typeColor;
    }
    for (int i = 0; i < blocks.Length; i++)
    {
        var palInfoByte = palInfo[i/4];
        int parByteNo = i % 4;
        blocks[i].typeColor = (byte)((palInfoByte >> parByteNo*2) & 3);
    }
    //
    //rebuild blocks to dt2 blocks
    for (int i = 0; i < blocks.Length; i++)
    {
        blocks[i] = new Dt2ObjRec(blocks[i], i);
    }
    //
    return blocks;
  }
  
  public void setBlocksDt2(int blockIndex, ObjRec[] objects)
  {
    int addr = ConfigScript.getTilesAddr(blockIndex);
    int count = getBlocksCount();
    for (int i = 0; i < count; i++)
    {
        var obj = objects[i];
        Globals.romdata[addr + i] = (byte)obj.c1;
        Globals.romdata[addr + count * 1 + i] = (byte)obj.c2;
        Globals.romdata[addr + count * 2 + i] = (byte)obj.c3;
        Globals.romdata[addr + count * 3 + i] = (byte)obj.c4;
    }
    
    int palInfoCount = getBlocksCount()/4;
    for (int i = 0; i < palInfoCount; i++)
    {
        var palInfoByte = 
          (objects[i*4+0].typeColor<<0) | 
          (objects[i*4+1].typeColor<<2) |
          (objects[i*4+2].typeColor<<4) | 
          (objects[i*4+3].typeColor<<6);
          
        Globals.romdata[addr + count * 4 + i] = (byte)palInfoByte;
    }
  }
  //--------------------------------------------------------------------------------------------
}