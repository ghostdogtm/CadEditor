using CadEditor;
using System.Collections.Generic;
//css_include Settings_CapcomBase.cs;

public class Data:CapcomBase
{
  public string[] getPluginNames() 
  {
    return new string[] 
    {
      "PluginChrView.dll",
      "PluginEditLayout.dll",
      "PluginAnimEditor.dll",
    };
  }
 
  //--------------------------------------------------------------------------------------------
  public override int getBigBlocksCount() { return 512; }
  public bool isShowScrollsInLayout()     { return false; }
  
  public OffsetRec getPalOffset()       { return new OffsetRec(0x1DA44, 10  , 16);     }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0x4D10 , 6   , 0xD00);  }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0x10   , 8   , 0xD00);  }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x7310 , 3   , 0x4000); }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x7B10 , 3   , 0x4000); }
  public OffsetRec getScreensOffset()   { return new OffsetRec(0x10058, 300 , 0x48);   }

  public IList<LevelRec> getLevelRecs()  { return levelRecsDt; }
  public string[] getBlockTypeNames()    { return objTypesDt;  }
  public GetObjectsFunc getObjectsFunc() { return getObjectsDt; }
  public SetObjectsFunc setObjectsFunc() { return setObjectsDt; }
  public GetBigTileNoFromScreenFunc getBigTileNoFromScreenFunc() { return getBigTileNoFromScreen; }
  public SetBigTileToScreenFunc     setBigTileToScreenFunc()     { return setBigTileToScreen; }
  
  public string getObjTypesPicturesDir() { return "obj_sprites_dt_1"; }
  
  public override GetVideoPageAddrFunc getVideoPageAddrFunc() { return getDuckTalesVideoAddress; }
  public override GetVideoChunkFunc    getVideoChunkFunc()    { return getDuckTalesVideoChunk;   }
  
  public IList<LevelRec> levelRecsDt = new List<LevelRec>() 
  {
    new LevelRec(0x1B43B, 181, 8, 7, 0x1CE7B),
    new LevelRec(0x1B6CC, 156, 8, 8, 0x1CEB3),
    new LevelRec(0x1B8E8, 126, 8, 6, 0x1CEF3),
    new LevelRec(0x1BAD1, 119, 8, 6, 0x1CF23),
    new LevelRec(0x1BD70, 182, 8, 6, 0x1CF53),
  };
  
  public GroupRec[] getGroups()
  {
    return new GroupRec[] { 
      new GroupRec("Amazon"         , 1,0,0,0, 0x01),
      new GroupRec("Transylvania"   , 2,1,1,1, 0x2C),
      new GroupRec("African Mines"  , 3,1,1,2, 0x4B),
      new GroupRec("Himalayas"      , 4,2,2,3, 0x7C),
      new GroupRec("Moon"           , 5,2,2,4, 0x9E),
    };
  }
  
  string[] objTypesDt = new[] {
    "0 (back)","1 (block)","2 ()","3 ()","4 ()","5 ()","6","7",
    "8","9","A","B","C","D","E","F"
  };
  
  //--------------------------------------------------------------------------------------------
  //duck tales specific
  
  public int getDuckTalesVideoAddress(int id)
  {
    if (id == 0x90) return 0x4010;
    if (id == 0x91) return 0x4D10;
    if (id == 0x92) return 0x5A10;
    if (id == 0x93) return 0x7D10;
    if (id == 0x94) return 0x8A10;
    if (id == 0x95) return 0x9710;
    return -1;
  }
  
  public byte[] getDuckTalesVideoChunk(int videoPageId)
  {
    //anim editor hack
    if (videoPageId < 0x90)
    {
      var ptrs = new int[] { 
        0x10  , 0x110 , 0x210, 0x310, 0x410, 0x510, 0x610, 0x710,
        0x1710, 0x1410, 0xE10, 0xF10, 0xC10, 0xD10, 0x810, 0x910 };
      return Utils.readVideoBankFrom16Pointers(ptrs);
    }
    
    //background
    byte[] videoChunk = Utils.getVideoChunk(videoPageId);
    //fill first quarter of videoChunk with constant to all video memory data
    for (int i = 0; i < 16 * 16 * 3; i++)
        videoChunk[i] = Globals.romdata[0x4010 + i];
    return videoChunk;
  }
  
  //convert object index to screen Y coord
  private byte convertObjectIndexToScreenYcoord(byte[] objLineOffsets, int index)
  {
      for (int i = 1; i < objLineOffsets.Length; i++)
          if (index < objLineOffsets[i])
              return (byte)(i-1);
      return (byte)(objLineOffsets.Length - 1);
  }
  
  public List<ObjectList> getObjectsDt(int levelNo)
  {
    LevelRec lr = ConfigScript.getLevelRec(levelNo);
    int objCount = lr.objCount, addr = lr.objectsBeginAddr;
    var objects = new List<ObjectRec>();
    var objLineOffsets = new byte[lr.height];
    for (int i = 0; i < lr.height; i++)
    {
        objLineOffsets[i] = Globals.romdata[addr + i - lr.height];
    }
    for (int i = 0; i < objCount; i++)
    {
        byte v = Globals.romdata[addr + i];
        byte sx = Globals.romdata[addr - 3 * objCount + i - lr.height];
        byte x = Globals.romdata[addr - 2 * objCount + i - lr.height];
        byte y = Globals.romdata[addr - objCount + i - lr.height];
        byte sy = convertObjectIndexToScreenYcoord(objLineOffsets, i);
        var obj = new ObjectRec(v, sx, sy, x, y);
        objects.Add(obj);
    }
    return new List<ObjectList> { new ObjectList { objects = objects, name = "Objects" } };
  }

  public bool setObjectsDt(int levelNo, List<ObjectList> objLists)
  {
    //todo: add save sy coord to objLineOffsets array
    LevelRec lr = ConfigScript.getLevelRec(levelNo);
    int addrBase = lr.objectsBeginAddr;
    int objCount = lr.objCount;
    var objects = objLists[0].objects;
    for (int i = 0; i < objects.Count; i++)
    {
        var obj = objects[i];
        Globals.romdata[addrBase + i] = (byte)obj.type;
        Globals.romdata[addrBase - 3 * objCount + i - lr.height] = (byte)obj.sx;
        Globals.romdata[addrBase - 2 * objCount + i - lr.height] = (byte)obj.x;
        Globals.romdata[addrBase - 1 * objCount + i - lr.height] = (byte)obj.y;
    }
    for (int i = objects.Count; i < objCount; i++)
    {
        Globals.romdata[addrBase + i] = 0xFF;
        Globals.romdata[addrBase - 3 * objCount + i - lr.height] = 0xFF;
        Globals.romdata[addrBase - 2 * objCount + i - lr.height] = 0xFF;
        Globals.romdata[addrBase - 1 * objCount + i - lr.height] = 0xFF;
    }
    return true;
  }
  
  public static int getBigTileNoFromScreen(int[] screenData, int index)
  {
    int noY = index % 8;
    int noX = index / 8;
    int lineByte = screenData[0x40 + noX];
    int addValue = (lineByte & (1 << (7 - noY))) != 0 ? 256 : 0;
    return addValue + screenData[index];
  }

  public static void setBigTileToScreen(int[] screenData, int index, int value)
  {
    bool hiPart = value > 0xFF;
    int noY = index % 8;
    int noX = index / 8;
    int lineByte = screenData[0x40 + noX];
    int mask = 1 << (7 - noY);
    if (hiPart)
        lineByte |= mask;
    else
        lineByte &= ~mask;
    screenData[index] = (byte)value;
    screenData[0x40 + noX] = (byte)lineByte;
  }
  //--------------------------------------------------------------------------------------------
  //Anim Editor
  public static int getAnimCount()   { return 144; }
  public static int getAnimAddrHi()  { return Utils.getRomAddr(5, 0xB257); }
  public static int getAnimAddrLo()  { return Utils.getRomAddr(5, 0xB1C7); }
  public static int getFrameCount()  { return 248; }
  public static int getFrameAddrHi() { return Utils.getRomAddr(5, 0x9779); }
  public static int getFrameAddrLo() { return Utils.getRomAddr(5, 0x9681); }
  public static int getCoordCount()  { return 224; }
  public static int getCoordAddrHi() { return Utils.getRomAddr(5, 0xAEC1); }
  public static int getCoordAddrLo() { return Utils.getRomAddr(5, 0xADE1); }
  public static byte[] getAnimPal()  { return new byte[] { 0x0F, 0x0F, 0x20, 0x16, 0x0F, 0x0F, 0x20, 0x27, 0x0F, 0x0f, 0x31, 0x27, 0x0F, 0x0F, 0x20, 0x19 }; }
  public static int getAnimBankNo()  { return 5;}
}