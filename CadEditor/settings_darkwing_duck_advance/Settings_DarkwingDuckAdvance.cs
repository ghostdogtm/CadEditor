using CadEditor;
using System.Collections.Generic;
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
  public OffsetRec getPalOffset()       { return new OffsetRec(0x1C010, 32  , 16);     }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0x50010, 32  , 0x1000); }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0x40010, 32  , 0x1000); }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x36F0 , 8   , 0x4000); }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x3AF0 , 8   , 0x4000); }
  public OffsetRec getScreensOffset()   { return new OffsetRec(0x10   , 300 , 0x40);   }
  public IList<LevelRec> getLevelRecs() { return levelRecsDwd; }
  public string[] getBlockTypeNames()   { return objTypesDwd;  }
  public GetObjectsFunc getObjectsFunc() { return getObjectsDwd; }
  public SetObjectsFunc setObjectsFunc() { return setObjectsDwd; }
  
  public string getObjTypesPicturesDir() { return "../settings_darkwing_duck/obj_sprites_dwd"; }
  
  public IList<LevelRec> levelRecsDwd = new List<LevelRec>() 
  {
    new LevelRec(0x10315, 51, 17, 4,  0x3DFA0),
    new LevelRec(0x10438, 60, 17, 4,  0x3DFE4), 
    new LevelRec(0x10584, 68, 17, 4,  0x3E028),  
    new LevelRec(0x106A0, 54, 10, 12, 0x3E06C), 
    new LevelRec(0x10816, 80, 19, 3,  0x3E0E4),  
    new LevelRec(0x10962, 63, 19, 3,  0x3E11D),  
    new LevelRec(0x10A89, 58, 19, 3,  0x3E156),  
  };
  
  string[] objTypesDwd =
  new[] {
      "0 (back)","1 (hook)","2 (platform)","3 (block)","4 (spikes)","5 (door)",
      "6","7","8","9","A","B","C","D","E","F"
  };
  
  public List<ObjectList> getObjectsDwd(int levelNo)
  {
      LevelRec lr = ConfigScript.getLevelRec(levelNo);
      int objCount = lr.objCount, addr = lr.objectsBeginAddr;
      var objects = new List<ObjectRec>();
      for (int i = 0; i < objCount; i++)
      {
          byte v = Globals.romdata[addr + i];
          byte sx, sy, x, y;
          sx = Globals.romdata[addr - 4 * objCount + i];
          x = Globals.romdata[addr - 3 * objCount + i];
          sy = Globals.romdata[addr - 2 * objCount + i];
          y = Globals.romdata[addr - objCount + i];
          var obj = new ObjectRec(v, sx, sy, x, y);
          objects.Add(obj);
      }
      return new List<ObjectList> { new ObjectList { objects = objects, name = "Objects" } };
  }
    
  public bool setObjectsDwd(int levelNo, List<ObjectList> objLists)
  {
      LevelRec lr = ConfigScript.getLevelRec(levelNo);
      int addrBase = lr.objectsBeginAddr;
      int objCount = lr.objCount;
      var objects = objLists[0].objects;
      for (int i = 0; i < objects.Count; i++)
      {
          var obj = objects[i];
          Globals.romdata[addrBase + i] = (byte)obj.type;
          Globals.romdata[addrBase - 4 * objCount + i] = (byte)obj.sx;
          Globals.romdata[addrBase - 3 * objCount + i] = (byte)obj.x;
          Globals.romdata[addrBase - 2 * objCount + i] = (byte)obj.sy;
          Globals.romdata[addrBase - 1 * objCount + i] = (byte)obj.y;
      }
      for (int i = objects.Count; i < objCount; i++)
      {
          Globals.romdata[addrBase + i] = 0xFF;
          Globals.romdata[addrBase - 4 * objCount + i] = 0xFF;
          Globals.romdata[addrBase - 3 * objCount + i] = 0xFF;
          Globals.romdata[addrBase - 2 * objCount + i] = 0xFF;
          Globals.romdata[addrBase - 1 * objCount + i] = 0xFF;
      }
      return true;
  }
}