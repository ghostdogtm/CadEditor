using CadEditor;
using System.Collections.Generic;


public class Data
{
  public bool isUseSegaGraphics()            { return true; }
  //public bool isBuildScreenFromSmallBlocks() { return true; }
  public int getWordLen()              { return 2;}
  
  public OffsetRec getPalOffset()       { return new OffsetRec(0x24DE42, 1, 64    );   }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x1E1FC0, 1, 0x8000);  }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getScreensOffset()   { return new OffsetRec(0, 1, 225*80);   }
  public int getBigBlocksCount()        { return 0x1000; }
  public int getScreenWidth()           { return 225; }
  public int getScreenHeight()          { return 80; }
  public IList<LevelRec> getLevelRecs() { return null; }
  
  public GetVideoChunkFunc    getVideoChunkFunc()    { return getVideoChuck;   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  public GetPalFunc           getPalFunc()           { return Utils.getPalleteLinear;}
  public SetPalFunc           setPalFunc()           { return null;}
  public GetObjectsFunc getObjectsFunc() { return null; }
  public SetObjectsFunc setObjectsFunc() { return null; }
  public ConvertScreenTileFunc getConvertScreenTileFunc() { return (v=>v/8);}
  public ConvertScreenTileFunc getBackConvertScreenTileFunc() { return (v=>v*8);}
  
  public byte[] getVideoChuck(int videoPageId)
  {
    return Utils.readBinFile("videoBack_1.bin");
  }
  
  public bool isBigBlockEditorEnabled() { return false;  }
  public bool isBlockEditorEnabled()    { return true;  }
  public bool isEnemyEditorEnabled()    { return false; }
  //--------------------------------------------------------------------------------------------
}