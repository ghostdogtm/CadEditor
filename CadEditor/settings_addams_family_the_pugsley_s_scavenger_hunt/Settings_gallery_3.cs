using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public OffsetRec getScreensOffset()  { return new OffsetRec( 0x04f36, 1 , 127*7);   }
  public int getScreenWidth()          { return 127; }
  public int getScreenHeight()         { return 7; }
  public string getBlocksFilename()    { return "gallery_3.png"; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
}