﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CSScriptLibrary;

namespace CadEditor
{
    public delegate int   GetVideoPageAddrFunc(int videoPageId);
    public delegate byte[] GetVideoChunkFunc(int videoPageId);
    public delegate void   SetVideoChunkFunc(int videoPageId, byte[] videoChunk);
    public delegate ObjRec[] GetBlocksFunc(int blockId);
    public delegate void   SetBlocksFunc(int blockIndex, ObjRec[] blocksData);
    public delegate BigBlock[] GetBigBlocksFunc(int bigBlockId);
    public delegate void   SetBigBlocksFunc(int bigTileIndex, BigBlock[] bigBlocks);
    public delegate byte[] GetSegaMappingFunc(int bigBlockId);
    public delegate void   SetSegaMappingFunc(int bigTileIndex, byte[] bigBlocks);
    public delegate byte[] GetPalFunc(int palId);
    public delegate void   SetPalFunc(int palId, byte[] pallete);
    public delegate void   RenderToMainScreenFunc(Graphics g, int curScale);
    public delegate List<ObjectList> GetObjectsFunc(int levelNo);
    public delegate bool            SetObjectsFunc(int levelNo, List<ObjectList> objects); 
    public delegate void            SortObjectsFunc(int levelNo, int listNo, List<ObjectRec> objects);
    public delegate LevelLayerData  GetLayoutFunc(int levelNo);
    public delegate Dictionary<String, int> GetObjectDictionaryFunc(int listNo, int objNo);
    public delegate int  ConvertScreenTileFunc(int val);
    public delegate int  GetBigTileNoFromScreenFunc(int[] screenData, int index);
    public delegate void SetBigTileToScreenFunc(int[] screenData, int index, int value);
    public delegate byte[] LoadSegaBackFunc();
    public delegate void SaveSegaBackFunc(byte[] data);
    public delegate void DrawObjectFunc(Graphics g, ObjectRec curObject, int listNo, bool selected, float curScale, ImageList objectSprites);
    public delegate void DrawObjectBigFunc(Graphics g, ObjectRec curObject, int listNo, bool selected, float curScale, Image[] objectSprites);

    public class ConfigScript
    {
        public static void LoadGlobalsFromFile(string fileName)
        {
            try
            {
                var asm = new AsmHelper(CSScript.Load(fileName));
                object data = asm.CreateObject("Config");
                romName = callFromScript(asm, data, "*.getFileName", "");
                cfgName = callFromScript(asm, data, "*.getConfigName", "");
                dumpName = callFromScript(asm, data, "*.getDumpName", "");
                showDumpFileField = callFromScript(asm, data, "*.showDumpFileField", false);
                nesColors = callFromScript<Color[]>(asm, data, "*.getNesColors", null);
            }
            catch (Exception)
            {
            }
        }

        public static void LoadStringsFromFile(string fileName)
        {
            try
            {
                var asm = new AsmHelper(CSScript.Load(fileName));
                object data = asm.CreateObject("Strings");
                Strings.FormMainName = callFromScript(asm, data, "*.getNesColors", "");
            }
            catch (Exception)
            {
            }
        }

        private static void addPlugin(string pluginName)
        {
            var plugin = PluginLoader.loadPlugin<IPlugin>(pluginName);
            if (plugin != null)
                plugins.Add(plugin);
        }

        private static void loadPluginWithSilentCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
            }
        }

        public static void LoadFromFile(string fileName)
        {
            var asm = new AsmHelper(CSScript.Load(fileName));
            object data;
            try
            {
                data = asm.CreateObject("Data");
            }
            catch (Exception)
            {
                return;
            }


            programStartDirectory = AppDomain.CurrentDomain.BaseDirectory;
            configDirectory       = Path.GetDirectoryName(fileName);
            if (configDirectory != "")
                changeToConfigDirectory();
            Globals.setGameType(callFromScript(asm, data, "*.getGameType", GameType.Generic));

            levelsCount = callFromScript(asm, data, "*.getLevelsCount", 1);
            screensOffset = new OffsetRec[levelsCount];

            palOffset = callFromScript(asm, data,"*.getPalOffset", new OffsetRec(0,1,0));
            videoOffset = callFromScript(asm, data, "*.getVideoOffset", new OffsetRec(0, 1, 0));
            videoObjOffset = callFromScript(asm, data, "*.getVideoObjOffset", new OffsetRec(0, 1, 0));
            bigBlocksOffset = callFromScript(asm, data, "*.getBigBlocksOffset", new OffsetRec(0, 1, 0));
            blocksOffset = callFromScript(asm, data, "*.getBlocksOffset", new OffsetRec(0, 1, 0));
            screensOffset[0]        = callFromScript(asm, data, "*.getScreensOffset", new OffsetRec(0, 1, 0));
            screensOffset[0].width  = callFromScript(asm, data, "*.getScreenWidth", 8);
            screensOffset[0].height = callFromScript(asm, data, "*.getScreenHeight", 8);
            if ((screensOffset[0].beginAddr == 0) && (screensOffset[0].recSize == 0))
            {
                screensOffset = callFromScript(asm, data, "*.getScreensOffsetsForLevels", new OffsetRec[1]);
            }
            screensOffset2 = callFromScript(asm, data, "*.getScreensOffset2", new OffsetRec(0, 1, 0));
            screenVertical = callFromScript(asm, data, "*.getScreenVertical", false);
            screenDataStride = callFromScript(asm, data, "*.getScreenDataStride", 1);
            wordLen = callFromScript(asm, data, "*.getWordLen", 1);
            littleEndian = callFromScript(asm, data, "*.isLittleEndian", false);
            useSegaGraphics = callFromScript(asm, data, "*.isUseSegaGraphics", false);
            blockSize4x4 = callFromScript(asm, data, "*.isBlockSize4x4", false);
            buildScreenFromSmallBlocks = callFromScript(asm, data, "isBuildScreenFromSmallBlocks", false);
            layersCount = callFromScript(asm, data, "*.getLayersCount", 1);
            levelRecs = callFromScript(asm, data,"*.getLevelRecs", new List<LevelRec>());

            //todo: remove or change to many lists interface
            minObjCoordX = callFromScript(asm, data, "*.getMinObjCoordX", 0);
            minObjCoordY = callFromScript(asm, data, "*.getMinObjCoordY", 0);
            minObjType   = callFromScript(asm, data, "*.getMinObjType"  , 0);
            maxObjCoordX = callFromScript(asm, data, "*.getMaxObjCoordX", -1); //ConfigScript.getScreenWidth() * 32
            maxObjCoordY = callFromScript(asm, data, "*.getMaxObjCoordY", -1); //ConfigScript.getScreenHeight() * 32;
            maxObjType   = callFromScript(asm, data, "*.getMaxObjType"  , -1); //256

            getVideoPageAddrFunc = callFromScript <GetVideoPageAddrFunc>(asm, data, "*.getVideoPageAddrFunc");
            getVideoChunkFunc = callFromScript<GetVideoChunkFunc>(asm, data, "*.getVideoChunkFunc");
            setVideoChunkFunc = callFromScript<SetVideoChunkFunc>(asm, data, "*.setVideoChunkFunc");
            getBigBlocksFunc = callFromScript<GetBigBlocksFunc>(asm, data, "*.getBigBlocksFunc");
            setBigBlocksFunc = callFromScript<SetBigBlocksFunc>(asm, data, "*.setBigBlocksFunc");
            getSegaMappingFunc = callFromScript<GetSegaMappingFunc>(asm, data, "*.getSegaMappingFunc", Utils.readLinearBigBlockData);
            setSegaMappingFunc = callFromScript<SetSegaMappingFunc>(asm, data, "*.setSegaMappingFunc", Utils.writeLinearBigBlockData);
            getBlocksFunc = callFromScript<GetBlocksFunc>(asm,data,"*.getBlocksFunc");
            setBlocksFunc = callFromScript<SetBlocksFunc>(asm, data, "*.setBlocksFunc");
            getPalFunc = callFromScript<GetPalFunc>(asm, data, "*.getPalFunc");
            setPalFunc = callFromScript<SetPalFunc>(asm, data, "*.setPalFunc");
            getObjectsFunc = callFromScript<GetObjectsFunc>(asm, data, "*.getObjectsFunc");
            setObjectsFunc = callFromScript<SetObjectsFunc>(asm, data, "*.setObjectsFunc");
            sortObjectsFunc = callFromScript<SortObjectsFunc>(asm, data, "*.sortObjectsFunc");
            getLayoutFunc = callFromScript<GetLayoutFunc>(asm, data, "*.getLayoutFunc");
            convertScreenTileFunc = callFromScript<ConvertScreenTileFunc>(asm, data, "*.getConvertScreenTileFunc");
            backConvertScreenTileFunc = callFromScript<ConvertScreenTileFunc>(asm, data, "*.getBackConvertScreenTileFunc");
            getBigTileNoFromScreenFunc = callFromScript<GetBigTileNoFromScreenFunc>(asm, data, "*.getBigTileNoFromScreenFunc", Utils.getBigTileNoFromScreen);
            setBigTileToScreenFunc = callFromScript<SetBigTileToScreenFunc>(asm, data, "*.setBigTileToScreenFunc", Utils.setBigTileToScreen);
            getObjectDictionaryFunc = callFromScript<GetObjectDictionaryFunc>(asm, data, "*.getObjectDictionaryFunc");
            loadSegaBackFunc = callFromScript<LoadSegaBackFunc>(asm, data, "*.loadSegaBackFunc");
            saveSegaBackFunc = callFromScript<SaveSegaBackFunc>(asm, data, "*.saveSegaBackFunc");
            segaBackWidth  = callFromScript(asm, data, "*.getSegaBackWidth", 64);
            segaBackHeight = callFromScript(asm, data, "*.getSegaBackHeight", 32);

            drawObjectFunc = callFromScript<DrawObjectFunc>(asm, data, "*.getDrawObjectFunc");
            drawObjectBigFunc = callFromScript<DrawObjectBigFunc>(asm, data, "*.getDrawObjectBigFunc");

            renderToMainScreenFunc = callFromScript<RenderToMainScreenFunc>(asm, data, "*.getRenderToMainScreenFunc");

            isBigBlockEditorEnabled = callFromScript(asm, data, "*.isBigBlockEditorEnabled", true);
            isBlockEditorEnabled = callFromScript(asm, data, "*.isBlockEditorEnabled", true);
            isEnemyEditorEnabled = callFromScript(asm, data, "*.isEnemyEditorEnabled", true);
            objTypesPicturesDir = callFromScript(asm, data, "*.getObjTypesPicturesDir", "obj_sprites");

            showScrollsInLayout = callFromScript(asm, data, "*.isShowScrollsInLayout", true);
            scrollsOffsetFromLayout = callFromScript(asm, data, "*.getScrollsOffsetFromLayout", 0);

            bigBlocksCount = callFromScript(asm, data, "*.getBigBlocksCount", 256);
            blocksCount    = callFromScript(asm, data, "*.getBlocksCount"   , 256);

            blocksPicturesFilename  = callFromScript(asm, data, "getBlocksFilename", "");
            if (blocksPicturesFilename != "" && !File.Exists(blocksPicturesFilename))
                throw new Exception("File does not exists: " + blocksPicturesFilename);
            blocksPicturesFilenames = callFromScript<string[]>(asm, data, "getBlocksFilenames", null);
            if (blocksPicturesFilenames!=null)
              for (int i = 0; i < blocksPicturesFilenames.Length; i++)
                if (!File.Exists(blocksPicturesFilenames[i]))
                    throw new Exception("File does not exists: " + blocksPicturesFilenames[i]);
            blocksPicturesWidth = callFromScript(asm, data, "getPictureBlocksWidth", 32); 
            usePicturesInstedBlocks = blocksPicturesFilename != "" || blocksPicturesFilenames != null;

            blockTypeNames = callFromScript(asm, data, "getBlockTypeNames", defaultBlockTypeNames);

            groups = callFromScript(asm, data, "getGroups", new GroupRec[0]);

            loadAllPlugins(asm, data);
        }

        private static void loadAllPlugins(AsmHelper asm, object data)
        {
            changeToProgramDirectory();
            cleanPlugins();
            loadGlobalPlugins();
            loadPluginsFromCurrentConfig(asm, data);
            changeToConfigDirectory();
        }

        private static void cleanPlugins()
        {
            plugins.Clear();
            videoNes = null;
            videoSega = null;
        }

        private static void loadGlobalPlugins()
        {
            //auto load plugins
            //loadPluginWithSilentCatch(() => addPlugin("PluginChrView.dll"));
            loadPluginWithSilentCatch(() => addPlugin("PluginExportScreens.dll"));
            loadPluginWithSilentCatch(() => addPlugin("PluginHexEditor.dll"));
            //loadPluginWithSilentCatch(() => addPlugin("PluginAnimEditor.dll"));
            //loadPluginWithSilentCatch(() => addPlugin("PluginEditLayout.dll"));
            //loadPluginWithSilentCatch(()=>addPlugin("PluginMapEditor.dll"));
            //loadPluginWithSilentCatch(()=>addPlugin("PluginLevelParamsCad.dll"));

            //auto load video plugins
            loadPluginWithSilentCatch(() => videoNes = PluginLoader.loadPlugin<IVideoPluginNes>("PluginVideoNes.dll"));
            loadPluginWithSilentCatch(() => videoSega = PluginLoader.loadPlugin<IVideoPluginSega>("PluginVideoSega.dll"));
        }

        private static void loadPluginsFromCurrentConfig(AsmHelper asm, object data)
        {
            string[] pluginNames = callFromScript(asm, data, "getPluginNames", new string[0]);
            foreach (var pluginName in pluginNames)
            {
                var p = PluginLoader.loadPlugin<IPlugin>(pluginName);
                if (p != null)
                {
                    p.loadFromConfig(asm, data);
                    plugins.Add(p);
                }
            }
            plugins.Reverse();
        }

        //0x90 - background memory
        //0x91 - objects    memory
        public static int getVideoPageAddr(int id)
        {
            return getVideoPageAddrFunc(id);
        }

        public static byte[] getVideoChunk(int videoPageId)
        {
            return (getVideoChunkFunc ?? (_=>null))(videoPageId);
        }

        public static void setVideoChunk(int videoPageId, byte[] videoChunk)
        {
           setVideoChunkFunc(videoPageId, videoChunk);
        }

        public static BigBlock[] getBigBlocks(int bigBlockId)
        {
            return (getBigBlocksFunc ?? (_ => null))(bigBlockId);
        }

        public static void setBigBlocks(int bigTileIndex, BigBlock[] bigBlockIndexes)
        {
            setBigBlocksFunc(bigTileIndex, bigBlockIndexes);
        }

        public static byte[] getSegaMapping(int mappingIndex)
        {
            return (getSegaMappingFunc ?? (_ => null))(mappingIndex);
        }

        public static void setSegaMapping(int mappingIndex, byte[] mapping)
        {
            setSegaMappingFunc(mappingIndex, mapping);
        }

        public static ObjRec[] getBlocks(int bigBlockId)
        {
            return (getBlocksFunc ?? (_ => null))(bigBlockId);
        }

        public static void setBlocks(int bIndex, ObjRec[] blocks)
        {
            setBlocksFunc(bIndex, blocks);
        }

        public static byte[] getPal(int palId)
        {
            return (getPalFunc ?? (_ => null))(palId);
        }


        public static void setPal(int palId, byte[] pallete)
        {
            setPalFunc(palId, pallete);
        }

        public static List<ObjectList> getObjects(int levelNo)
        {
            return (getObjectsFunc ?? (_ => null))(levelNo);
        }

        public static void setObjects(int levelNo, List<ObjectList> objects)
        {
            setObjectsFunc(levelNo, objects);
        }
        
        public static void sortObjects(int levelNo, int listNo, List<ObjectRec> objects)
        {
            sortObjectsFunc(levelNo, listNo, objects);
        }

         public static int convertScreenTile(int tile)
         {
             return (convertScreenTileFunc ?? (v=>v))(tile);
         }

         public static int backConvertScreenTile(int tile)
         {
             return (backConvertScreenTileFunc ?? (v => v))(tile);
         }

         public static int getBigTileNoFromScreen(int[] screenData, int index)
         {
             return getBigTileNoFromScreenFunc(screenData, index);
         }

         public static void setBigTileToScreen(int[] screenData, int index, int value)
         {
             setBigTileToScreenFunc(screenData, index, value);
         }

         public static byte[] loadSegaBack()
         {
             return loadSegaBackFunc();
         }
         public static void saveSegaBack(byte[] data)
         {
             saveSegaBackFunc(data);
         }

         public static int getSegaBackWidth()
         {
             return segaBackWidth;
         }

         public static int getSegaBackHeight()
         {
             return segaBackHeight;
         }

        public static void drawObject(Graphics g, ObjectRec curObject, int listNo, bool selected, float curScale, ImageList objectSprites)
         {
             if (drawObjectFunc != null)
                 drawObjectFunc(g, curObject, listNo, selected, curScale, objectSprites);
             else
                 Utils.defaultDrawObject(g, curObject, listNo, selected, curScale, objectSprites);
         }

         public static void drawObjectBig(Graphics g, ObjectRec curObject, int listNo, bool selected, float curScale, Image[] objectSprites)
         {
             if (drawObjectBigFunc != null)
                 drawObjectBigFunc(g, curObject, listNo, selected, curScale, objectSprites);
             else
                 Utils.defaultDrawObjectBig(g, curObject, listNo, selected, curScale, objectSprites);
             
         }

        public static LevelLayerData getLayout(int levelNo)
        {
            return getLayoutFunc(levelNo);
        }

        public static Dictionary<String, int> getObjectDictionary(int listNo, int objType)
        {
            return (getObjectDictionaryFunc ?? ((_,__)=> null))(listNo, objType);
        }

        public static void renderToMainScreen(Graphics g, int scale)
        {
            if (renderToMainScreenFunc!=null)
                renderToMainScreenFunc(g, scale);
        }

        public static int getBigBlocksCount()
        {
            return bigBlocksCount;
        }

        public static int getBlocksCount()
        {
            return blocksCount;
        }

        public static LevelRec getLevelRec(int i)
        {
            return levelRecs[i];
        }

        public static int getMaxObjType()
        {
            return maxObjType;
        }

        public static int getMinObjType()
        {
            return minObjType;
        }

        public static string getObjTypesPicturesDir()
        {
            return objTypesPicturesDir;
        }

        public static string[] getBlockTypeNames()
        {
            return blockTypeNames;
        }

        public static bool getScreenVertical()
        {
            return screenVertical;
        }

        public static int getScreenDataStride()
        {
            return screenDataStride;
        }

        public static int getWordLen()
        {
            return wordLen;
        }

        public static bool isLittleEndian()
        {
            return littleEndian;
        }

        public static bool isBuildScreenFromSmallBlocks()
        {
            return buildScreenFromSmallBlocks;
        }

        public static int getBlocksPicturesWidth()
        {
            return blocksPicturesWidth;
        }

        public static int getLayersCount()
        {
            return layersCount;
        }

        public static bool isShowScrollsInLayout()
        {
            return showScrollsInLayout;
        }

        public static int getScrollsOffsetFromLayout()
        {
            return scrollsOffsetFromLayout;
        }

        public static int getLevelsCount()
        {
            return levelsCount;
        }

        public static bool isUseSegaGraphics()
        {
            return useSegaGraphics;
        }

        public static bool isBlockSize4x4()
        {
            return blockSize4x4;
        }

        public static GroupRec[] getGroups()
        {
            return groups;
        }

        public static GroupRec getGroup(int i)
        {
            return groups[i];
        }

          //------------------------------------------------------------
        //helpers
        public static int getScreenWidth(int levelNo)
        {
            return screensOffset[levelNo].width;
        }

        public static int getScreenHeight(int levelNo)
        {
            return screensOffset[levelNo].height;
        }

        public static int getLayoutAddr(int index)
        {
            return ConfigScript.getLevelRec(index).layoutAddr;
        }

        public static int getScrollAddr(int index)
        {
            return getLayoutAddr(index) + ConfigScript.getScrollsOffsetFromLayout();
        }

        public static int getTilesAddr(int id)
        {
            return ConfigScript.blocksOffset.beginAddr + ConfigScript.blocksOffset.recSize * id;
        }

        public static int getBigTilesAddr(int id)
        {
            return ConfigScript.bigBlocksOffset.beginAddr + ConfigScript.bigBlocksOffset.recSize * id;
        }

        public static int getLevelWidth(int levelNo)
        {
            return ConfigScript.getLevelRec(levelNo).width;
        }

        public static int getLevelHeight(int levelNo)
        {
            return ConfigScript.getLevelRec(levelNo).height;
        }
        //------------------------------------------------------------

        public static T callFromScript<T>(AsmHelper script, object data, string funcName, T defaultValue = default(T), params object[] funcParams)
        {
            try
            {
                return (T)script.InvokeInst(data, funcName, funcParams);
            }
            catch (Exception) //all exception catch...
            {
                return defaultValue;
            }
        }

        public static void changeToProgramDirectory()
        {
            Directory.SetCurrentDirectory(programStartDirectory);
        }
        public static void changeToConfigDirectory()
        {
            Directory.SetCurrentDirectory(configDirectory);
        }

        private static string programStartDirectory;
        private static string configDirectory;

        public static OffsetRec palOffset;
        public static OffsetRec videoOffset;
        public static OffsetRec videoObjOffset;
        public static OffsetRec bigBlocksOffset;
        public static OffsetRec blocksOffset;
        public static OffsetRec[] screensOffset;
        public static OffsetRec screensOffset2;
        //public static OffsetRec boxesBackOffset;
        public static int levelsCount;
        public static int bigBlocksCount;
        public static int blocksCount;
        public static bool screenVertical;
        public static int screenDataStride;
        public static int layersCount;
        public static int wordLen;
        public static bool littleEndian;
        public static bool buildScreenFromSmallBlocks;

        public static bool useSegaGraphics;
        public static bool blockSize4x4;

        public static int minObjCoordX;
        public static int minObjCoordY;
        public static int minObjType;
        public static int maxObjCoordX;
        public static int maxObjCoordY;
        public static int maxObjType;

        public static int segaBackWidth;
        public static int segaBackHeight;

        public static IList<LevelRec> levelRecs;

        public static GetVideoPageAddrFunc getVideoPageAddrFunc;
        public static GetVideoChunkFunc getVideoChunkFunc;
        public static SetVideoChunkFunc setVideoChunkFunc;
        public static GetBigBlocksFunc getBigBlocksFunc;
        public static SetBigBlocksFunc setBigBlocksFunc;
        public static GetSegaMappingFunc getSegaMappingFunc;
        public static SetSegaMappingFunc setSegaMappingFunc;
        public static GetBlocksFunc getBlocksFunc;
        public static SetBlocksFunc setBlocksFunc;
        public static GetPalFunc getPalFunc;
        public static SetPalFunc setPalFunc;
        public static GetObjectsFunc getObjectsFunc;
        public static SetObjectsFunc setObjectsFunc;
        public static SortObjectsFunc sortObjectsFunc;
        public static GetLayoutFunc getLayoutFunc;
        public static GetObjectDictionaryFunc getObjectDictionaryFunc;
        public static RenderToMainScreenFunc renderToMainScreenFunc;
        public static ConvertScreenTileFunc convertScreenTileFunc;
        public static ConvertScreenTileFunc backConvertScreenTileFunc;
        public static GetBigTileNoFromScreenFunc getBigTileNoFromScreenFunc;
        public static SetBigTileToScreenFunc setBigTileToScreenFunc;
        public static LoadSegaBackFunc loadSegaBackFunc;
        public static SaveSegaBackFunc saveSegaBackFunc;
        public static DrawObjectFunc drawObjectFunc;
        public static DrawObjectBigFunc drawObjectBigFunc;

        public static bool isBigBlockEditorEnabled;
        public static bool isBlockEditorEnabled;
        public static bool isEnemyEditorEnabled;

        public static bool showScrollsInLayout;
        public static int scrollsOffsetFromLayout;

        public static bool usePicturesInstedBlocks;
        public static string blocksPicturesFilename;
        public static string[] blocksPicturesFilenames;
        public static int blocksPicturesWidth;
        public static string objTypesPicturesDir;

        public static GroupRec[] groups;

        public static string[] blockTypeNames;
        public static string[] defaultBlockTypeNames = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        //global editor settings
        public static string  romName;
        public static string dumpName;
        public static string  cfgName;
        public static Color[] nesColors;
        public static bool showDumpFileField;

        public static List<IPlugin> plugins = new List<IPlugin>();
        public static IVideoPluginNes videoNes;
        public static IVideoPluginSega videoSega;
    }
}
