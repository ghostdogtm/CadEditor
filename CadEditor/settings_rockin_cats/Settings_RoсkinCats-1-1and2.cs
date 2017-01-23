using CadEditor;
using System;
using System.Drawing;
//css_include Settings_RockinCats-Utils;

public class Data : RockinCatsBase
{
  public override OffsetRec getScreensOffset()  { return new OffsetRec(0x13779, 19 , 3*2);    }
  public override int getVideoIndex1()          { return 4; }
  public override int getVideoIndex2()          { return 6; }
  public override OffsetRec getBlocksOffset()   { return new OffsetRec(0x13117, 1  , 0x4000); }
  public override int getBlocksCount()          { return 124; }
  
  public override OffsetRec getBigBlocksOffsetHierarchy(int hierarchyLevel)
  { 
    if (hierarchyLevel == 0) { return new OffsetRec(0x13383, 1  , 0x4000); }
    if (hierarchyLevel == 1) { return new OffsetRec(0x13547, 1  , 0x4000); }
    if (hierarchyLevel == 2) { return new OffsetRec(0x136E3, 1  , 0x4000); }
    return new OffsetRec(0x0, 1  , 0x4000);
  }
  
  public override int getBigBlocksCountHierarchy(int hierarchyLevel)
  { 
    if (hierarchyLevel == 0) { return 113; }
    if (hierarchyLevel == 1) { return 103; }
    if (hierarchyLevel == 2) { return 75;  }
    return 256;
  }
  
  public override byte[] getPallete(int palId)
  {
    var pallete = new byte[] { 
      0x0f, 0x16, 0x28, 0x30, 0x0f, 0x0a, 0x07, 0x17,
      0x0f, 0x07, 0x00, 0x10, 0x0f, 0x02, 0x12, 0x32,
    }; 
    return pallete;
  }
}