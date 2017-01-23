using CadEditor;
using System.Collections.Generic;
public class Data
{ 
  public OffsetRec getScreensOffset()     { return new OffsetRec(194860   , 1 , 9*112);  }
  public int getScreenWidth()    { return 9; }
  public int getScreenHeight()   { return 112; }
  public int getBigBlocksCount() { return 110; }
  public int getBlocksCount()    { return 110; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return true; }
  public bool isEnemyEditorEnabled()    { return false; }
  
    public bool isBuildScreenFromSmallBlocks() { return true; }
  
  public GetVideoPageAddrFunc getVideoPageAddrFunc() { return getVideoAddress; }
  public GetVideoChunkFunc    getVideoChunkFunc()    { return getVideoChunk;   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x2C76C , 1  , 0x1000);  }
  public int getPalBytesAddr()          { return 0x2CE4C; }
  public GetBlocksFunc        getBlocksFunc() { return Utils.getBlocksFromTiles16Pal1;}
  public SetBlocksFunc        setBlocksFunc() { return Utils.setBlocksFromTiles16Pal1;}
  
  public GetPalFunc           getPalFunc()           { return getPallete;}
  public SetPalFunc           setPalFunc()           { return null;}
  
  //----------------------------------------------------------------------------
  public int getVideoAddress(int id)
  {
    return -1;
  }
  
  public byte[] getVideoChunk(int videoPageId)
  {
     return Utils.readVideoBankFromFile("ppu_dump8.bin", videoPageId);
  }
  
  public byte[] getPallete(int palId)
  {
    var pallete = new byte[] { 
      0x0f, 0x15, 0x25, 0x35, 0x0f, 0x07, 0x05, 0x15,
      0x0f, 0x15, 0x25, 0x20, 0x0f, 0x09, 0x19, 0x2a
    }; 
    return pallete;
  }
}