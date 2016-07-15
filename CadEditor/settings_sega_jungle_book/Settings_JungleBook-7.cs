using CadEditor;
using System.Collections.Generic;

public class Data
{
  public string[] getPluginNames() 
  {
    return new string[] 
    {
      "PluginSegaBackEditor.dll",
    };
  }
  
  public bool isUseSegaGraphics()            { return true; }
  //public bool isBuildScreenFromSmallBlocks() { return true; }
  public int getWordLen()              { return 2;}
  
  public OffsetRec getPalOffset()       { return new OffsetRec(0xe986e, 1, 64    );   }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x173546, 1, 0x8000);  }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0, 1, 0     );   }
  public OffsetRec getScreensOffset()   { return new OffsetRec(0, 1, 128*82);   }
  public int getBigBlocksCount()        { return 0x1000; }
  public int getScreenWidth()           { return 128; }
  public int getScreenHeight()          { return 82; }
  public IList<LevelRec> getLevelRecs() { return null; }
  
  public GetVideoChunkFunc    getVideoChunkFunc()    { return getVideoChuck;   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  public GetPalFunc           getPalFunc()           { return Utils.getPalleteLinear;}
  public SetPalFunc           setPalFunc()           { return null;}
  public GetObjectsFunc getObjectsFunc() { return null; }
  public SetObjectsFunc setObjectsFunc() { return null; }
  public ConvertScreenTileFunc getConvertScreenTileFunc() { return (v=>v/8);}
  public ConvertScreenTileFunc getBackConvertScreenTileFunc() { return (v=>v*8);}
  
  public LoadSegaBackFunc     loadSegaBackFunc()     { return loadBack;}
  public SaveSegaBackFunc     saveSegaBackFunc()     { return saveBack;}
  public int getSegaBackWidth()  { return 64; }
  public int getSegaBackHeight() { return 32; }
  
  private string BACK_NAME   = "SegaJungleBookBack_7.bin";
  
  public byte[] loadBack()
  {
    return Utils.loadDataFromFile(BACK_NAME);
  }
  
  public void saveBack(byte[] data)
  {
    Utils.saveDataToFile(BACK_NAME, data);
  }
  
  public byte[] getVideoChuck(int videoPageId)
  {
    return Utils.readBinFile("videoBack_7.bin");
  }
  
  public bool isBigBlockEditorEnabled() { return false;  }
  public bool isBlockEditorEnabled()    { return true;  }
  public bool isEnemyEditorEnabled()    { return false; }
  //--------------------------------------------------------------------------------------------
}