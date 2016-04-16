using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public OffsetRec getScreensOffset()  { return new OffsetRec( 0x10b20, 1 , 24*24);   }
  public int getScreenWidth()          { return 24; }
  public int getScreenHeight()         { return 24; }
  public string getBlocksFilename()    { return "hook_1.png"; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
}