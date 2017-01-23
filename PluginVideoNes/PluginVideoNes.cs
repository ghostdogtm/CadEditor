﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using CadEditor;

namespace PluginVideoNes
{
    public class Video : IVideoPluginNes
    {
        public string getName()
        {
            return "Nes Video Plugin";
        }
        static Video()
        {
            nesColors[0] = Color.FromArgb(124, 124, 124);
            nesColors[1] = Color.FromArgb(0, 0, 252);
            nesColors[2] = Color.FromArgb(0, 0, 188);
            nesColors[3] = Color.FromArgb(68, 40, 188);
            nesColors[4] = Color.FromArgb(148, 0, 132);
            nesColors[5] = Color.FromArgb(168, 0, 32);
            nesColors[6] = Color.FromArgb(168, 16, 0);
            nesColors[7] = Color.FromArgb(136, 20, 0);
            nesColors[8] = Color.FromArgb(80, 48, 0);
            nesColors[9] = Color.FromArgb(0, 120, 0);
            nesColors[0xA] = Color.FromArgb(0, 104, 0);
            nesColors[0xB] = Color.FromArgb(0, 88, 0);
            nesColors[0xC] = Color.FromArgb(0, 64, 88);
            nesColors[0xD] = Color.FromArgb(0, 0, 0);
            nesColors[0xE] = Color.FromArgb(0, 0, 0);
            nesColors[0xF] = Color.FromArgb(0, 0, 0);

            nesColors[0x10] = Color.FromArgb(188, 188, 188);
            nesColors[0x11] = Color.FromArgb(0, 120, 248);
            nesColors[0x12] = Color.FromArgb(0, 88, 248);
            nesColors[0x13] = Color.FromArgb(104, 68, 252);
            nesColors[0x14] = Color.FromArgb(216, 0, 204);
            nesColors[0x15] = Color.FromArgb(228, 0, 88);
            nesColors[0x16] = Color.FromArgb(248, 56, 0);
            nesColors[0x17] = Color.FromArgb(228, 92, 16);
            nesColors[0x18] = Color.FromArgb(172, 124, 0);
            nesColors[0x19] = Color.FromArgb(0, 184, 0);
            nesColors[0x1A] = Color.FromArgb(0, 168, 0);
            nesColors[0x1B] = Color.FromArgb(0, 168, 68);
            nesColors[0x1C] = Color.FromArgb(0, 136, 136);
            nesColors[0x1D] = Color.FromArgb(0, 0, 0);
            nesColors[0x1E] = Color.FromArgb(0, 0, 0);
            nesColors[0x1F] = Color.FromArgb(0, 0, 0);

            nesColors[0x20] = Color.FromArgb(248, 248, 248);
            nesColors[0x21] = Color.FromArgb(60, 188, 252);
            nesColors[0x22] = Color.FromArgb(104, 136, 252);
            nesColors[0x23] = Color.FromArgb(152, 120, 248);
            nesColors[0x24] = Color.FromArgb(248, 120, 248);
            nesColors[0x25] = Color.FromArgb(248, 88, 152);
            nesColors[0x26] = Color.FromArgb(248, 120, 88);
            nesColors[0x27] = Color.FromArgb(252, 160, 68);
            nesColors[0x28] = Color.FromArgb(248, 184, 0);
            nesColors[0x29] = Color.FromArgb(184, 248, 24);
            nesColors[0x2A] = Color.FromArgb(88, 216, 84);
            nesColors[0x2B] = Color.FromArgb(88, 248, 152);
            nesColors[0x2C] = Color.FromArgb(0, 232, 216);
            nesColors[0x2D] = Color.FromArgb(120, 120, 120);
            nesColors[0x2E] = Color.FromArgb(0, 0, 0);
            nesColors[0x2F] = Color.FromArgb(0, 0, 0);

            nesColors[0x30] = Color.FromArgb(252, 252, 252);
            nesColors[0x31] = Color.FromArgb(164, 228, 252);
            nesColors[0x32] = Color.FromArgb(184, 184, 248);
            nesColors[0x33] = Color.FromArgb(216, 184, 248);
            nesColors[0x34] = Color.FromArgb(248, 184, 248);
            nesColors[0x35] = Color.FromArgb(248, 164, 192);
            nesColors[0x36] = Color.FromArgb(240, 208, 176);
            nesColors[0x37] = Color.FromArgb(252, 224, 168);
            nesColors[0x38] = Color.FromArgb(248, 216, 120);
            nesColors[0x39] = Color.FromArgb(216, 248, 120);
            nesColors[0x3A] = Color.FromArgb(184, 248, 184);
            nesColors[0x3B] = Color.FromArgb(184, 248, 216);
            nesColors[0x3C] = Color.FromArgb(0, 252, 252);
            nesColors[0x3D] = Color.FromArgb(248, 216, 248);
            nesColors[0x3E] = Color.FromArgb(0, 0, 0);
            nesColors[0x3F] = Color.FromArgb(0, 0, 0);

            CadObjectTypeColors[0x0] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x1] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x2] = Color.FromArgb(196, 0, 196, 0);
            CadObjectTypeColors[0x3] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x4] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x5] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x6] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x7] = Color.FromArgb(196, 255, 255, 0);
            CadObjectTypeColors[0x8] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x9] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xA] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xB] = Color.FromArgb(196, 0, 0, 0);
            CadObjectTypeColors[0xC] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xD] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xE] = Color.FromArgb(196, 0, 255, 255);
            CadObjectTypeColors[0xF] = Color.FromArgb(196, 0, 255, 255);
        }

        public void updateColorsFromConfig()
        {
            if (ConfigScript.nesColors != null)
                nesColors = ConfigScript.nesColors;
        }

        public Bitmap makeImage(int index, byte[] videoChunk, byte[] pallete, int subPalIndex, float scale, bool scaleAccurate = true, bool withAlpha = false)
        {
            Bitmap res = new Bitmap((int)(8 * scale), (int)(8 * scale));
            using (Graphics g = Graphics.FromImage(res))
            {
                int i = index;
                float bitmapScale = scaleAccurate ? scale : 1;
                int beginIndex = 16 * i;
                for (int line = 0; line < 8; line++)
                {
                    for (int pixel = 0; pixel < 8; pixel++)
                    {
                        bool bitLo = Utils.getBit(videoChunk[beginIndex + line], 8 - pixel);
                        bool bitHi = Utils.getBit(videoChunk[beginIndex + line + 8], 8 - pixel);
                        int palIndex = mixBits(bitHi, bitLo);
                        int fullPalIndex = subPalIndex * 4 + palIndex;
                        int colorNo = pallete[fullPalIndex];
                        Color c = (withAlpha && (fullPalIndex % 4 == 0)) ? Color.FromArgb(0) : nesColors[colorNo];
                        if (scaleAccurate && (scale > 1.0f))
                        {
                            int scaleInt = (int)scale;
                            for (int scaleFillX = 0; scaleFillX < scaleInt; scaleFillX++)
                                for (int scaleFillY = 0; scaleFillY < scaleInt; scaleFillY++)
                                    res.SetPixel(pixel * scaleInt + scaleFillX, line * scaleInt + scaleFillY, c);
                        }
                        else
                        {
                            if (scale > 1.0f)
                                res.SetPixel(pixel, line, c);
                            else
                                res.SetPixel((int)(pixel * scale), (int)(line * scale), c);
                        }
                    }
                }
            }
            return res;
        }

        public Bitmap makeImageStrip(byte[] videoChunk, byte[] pallete, int subPalIndex, float scale, bool scaleAccurate = true, bool withAlpha = false)
        {
            Bitmap res = new Bitmap((int)(8 * CHUNK_COUNT * scale), (int)(8 * scale));
            using (Graphics g = Graphics.FromImage(res))
            {
                for (int i = 0; i < CHUNK_COUNT; i++)
                {
                    float bitmapScale = scaleAccurate ? scale : 1;
                    Bitmap onePic = makeImage(i, videoChunk, pallete, subPalIndex, scale, scaleAccurate, withAlpha);
                    g.DrawImage(onePic, new Rectangle((int)(i * 8 * scale), 0, (int)(8 * scale), (int)(8 * scale)));
                }
            }
            return res;
        }

        public Bitmap makeImageRectangle(byte[] videoChunk, byte[] pallete, int subPalIndex, float scale, bool scaleAccurate = true, bool withAlpha = false)
        {
            var images = Enumerable.Range(0, 256).Select(i => makeImage(i, videoChunk, pallete, subPalIndex, scale, scaleAccurate, withAlpha));
            return UtilsGDI.GlueImages(images.ToArray(), 16, 16);
        }

        public Bitmap makeObject(int index, ObjRec[] objects, Bitmap[][] objStrips, float scale, MapViewType drawType, int constantSubpal = -1)
        {
            var obj = objects[index];
            int scaleInt16 = (int)(scale * 16);
            var images = new Image[obj.getSize()];
            for (int i = 0; i < obj.getSize(); i++)
            {
                int x = i % obj.w;
                int y = i / obj.w;
                int pali = (y >> 1) * (obj.w >> 1) + (x >> 1);
                images[i] = objStrips[obj.getSubpallete(pali)][obj.indexes[i]];
            }

            var mblock = UtilsGDI.GlueImages(images, obj.w, obj.h);
            using (Graphics g2 = Graphics.FromImage(mblock))
            {
                if (drawType == MapViewType.ObjType)
                {
                    g2.FillRectangle(new SolidBrush(CadObjectTypeColors[obj.getType()]), new Rectangle(0, 0, scaleInt16, scaleInt16));
                    g2.DrawString(String.Format("{0:X}", obj.getType()), new Font("Arial", 6), Brushes.White, new Point(0, 0));
                }
                else if (drawType == MapViewType.ObjNumbers)
                {
                    g2.FillRectangle(new SolidBrush(Color.FromArgb(192, 255, 255, 255)), new Rectangle(0, 0, scaleInt16, scaleInt16));
                    g2.DrawString(String.Format("{0:X}", index), new Font("Arial", 6), Brushes.Red, new Point(0, 0));
                }
            }
            return mblock;
        }

        public Bitmap makeObjectsStrip(byte videoPageId, byte tilesId, byte palId, float scale, MapViewType drawType, int constantSubpal = -1)
        {
            byte[] videoChunk = ConfigScript.getVideoChunk(videoPageId);
            int blocksCount = ConfigScript.getBlocksCount();
            ObjRec[] objects = ConfigScript.getBlocks(tilesId);

            byte[] palette = ConfigScript.getPal(palId);
            var range256 = Enumerable.Range(0, 256);
            var objStrip1 = range256.Select(i => makeImage(i, videoChunk, palette, 0, scale)).ToArray();
            var objStrip2 = range256.Select(i => makeImage(i, videoChunk, palette, 1, scale)).ToArray();
            var objStrip3 = range256.Select(i => makeImage(i, videoChunk, palette, 2, scale)).ToArray();
            var objStrip4 = range256.Select(i => makeImage(i, videoChunk, palette, 3, scale)).ToArray();
            var objStrips = new[] { objStrip1, objStrip2, objStrip3, objStrip4 };
            Bitmap res = new Bitmap((int)(16 * blocksCount * scale), (int)(16 * scale));
            using (Graphics g = Graphics.FromImage(res))
            {
                for (int i = 0; i < blocksCount; i++)
                {
                    var mblock = makeObject(i, objects, objStrips, scale, drawType, constantSubpal);
                    int scaleInt16 = (int)(scale * 16);
                    g.DrawImage(mblock, new Rectangle(i * scaleInt16, 0, scaleInt16, scaleInt16));
                }
            }
            return res;
        }

        //TODO: write universal "RectangulateStripImage function"
        //using makeObjectsStrip for now. Return rectangle small blocks objects
        public Bitmap makeObjectsRectangle(byte videoPageId, byte tilesId, byte palId, float scale, MapViewType drawType, int constantSubpal = -1)
        {
            Bitmap imageStrip = ConfigScript.videoNes.makeObjectsStrip(videoPageId, tilesId, palId, scale, drawType, constantSubpal);
            //print only first 256 blocks
            int BLOCKS_IN_ROW = 16;
            int BLOCKS_IN_COL = 16;
            Bitmap resultVideo = new Bitmap((int)(16*scale*BLOCKS_IN_ROW), (int)(16*scale*BLOCKS_IN_COL));
            using (Graphics g = Graphics.FromImage(resultVideo))
            {
                for (int i = 0; i < 256; i++)
                {
                    int size = (int)(16 * scale);
                    g.DrawImage(imageStrip, new Rectangle(i%16 * size, (i/16) *size, size, size), new Rectangle(i * size, 0, size, size) , GraphicsUnit.Pixel);
                }
            }
            return resultVideo;
        }

         public Image[] makeBigBlocks(int videoNo, int bigBlockNo, int blockNo, int palleteNo, MapViewType smallObjectsViewType = MapViewType.Tiles,
            float smallBlockScaleFactor = 2.0f, float curButtonScale = 2, MapViewType curViewType = MapViewType.Tiles, bool showAxis = false, int hierarchyLevel = 0)
        {
            byte blockIndexId = (byte)blockNo;
            BigBlock[] bigBlockIndexes = ConfigScript.getBigBlocksRecursive(hierarchyLevel, blockIndexId);
            return makeBigBlocks(videoNo, bigBlockNo, bigBlockIndexes, palleteNo, smallObjectsViewType, smallBlockScaleFactor, curButtonScale, curViewType, showAxis, hierarchyLevel);
        }

        public Image[] makeBigBlocks(int videoNo, int bigBlockNo, BigBlock[] bigBlockIndexes, int palleteNo, MapViewType smallObjectsViewType = MapViewType.Tiles,
            float smallBlockScaleFactor = 2.0f, float curButtonScale = 2, MapViewType curViewType = MapViewType.Tiles, bool showAxis = false, int hierarchyLevel = 0)
        {
            int blockCount = ConfigScript.getBigBlocksCount(hierarchyLevel);
            var bigBlocks = new Image[blockCount];

            byte blockId = (byte)bigBlockNo;
            byte backId = (byte)videoNo;
            byte palId = (byte)palleteNo;

            var smallBlocks = new System.Windows.Forms.ImageList();
            if (hierarchyLevel == 0)
            {
                var im = makeObjectsStrip(backId, blockId, palId, smallBlockScaleFactor, smallObjectsViewType);
                smallBlocks.ImageSize = new Size((int)(16 * smallBlockScaleFactor), (int)(16 * smallBlockScaleFactor));
                smallBlocks.Images.AddStrip(im);
            }
            else
            {
                var bigBlockIndexesPrev = ConfigScript.getBigBlocksRecursive(hierarchyLevel - 1, bigBlockNo);
                var ims = makeBigBlocks(videoNo, bigBlockNo, bigBlockIndexesPrev, palleteNo, smallObjectsViewType, smallBlockScaleFactor, curButtonScale, curViewType, false, hierarchyLevel - 1);
                smallBlocks.ImageSize = ims[0].Size;
                smallBlocks.Images.AddRange(ims);
            }
            Image[] smallBlocksPack = smallBlocks.Images.Cast<Image>().ToArray();

            //tt version hardcode
            Image[][] smallBlocksAll = null;

            bool smallBlockHasSubpals = bigBlockIndexes==null ? true : bigBlockIndexes[0].smallBlocksWithPal();
            if (!smallBlockHasSubpals)
            {
                smallBlocksAll = new Image[4][];
                for (int i = 0; i < 4; i++)
                {
                    var il = new ImageList();
                    il.ImageSize = new System.Drawing.Size((int)(16 * smallBlockScaleFactor), (int)(16 * smallBlockScaleFactor));
                    il.Images.AddStrip(makeObjectsStrip((byte)backId, (byte)blockId, (byte)palId, smallBlockScaleFactor, smallObjectsViewType, i));
                    smallBlocksAll[i] = il.Images.Cast<Image>().ToArray();
                }
            }
            else
            {
                smallBlocksAll = new Image[4][] { smallBlocksPack, smallBlocksPack, smallBlocksPack, smallBlocksPack } ;
            }

            for (int btileId = 0; btileId < blockCount; btileId++)
            {
                Image b;
                if (ConfigScript.isBuildScreenFromSmallBlocks())
                {
                    var sb = smallBlocks.Images[btileId];
                    b = UtilsGDI.ResizeBitmap(sb, (int)(sb.Width * curButtonScale * 2), (int)(sb.Height * curButtonScale * 2));
                }
                else
                {
                    b = bigBlockIndexes[btileId].makeBigBlock(smallBlocksAll);
                }
                if (curViewType == MapViewType.ObjNumbers)
                    b = VideoHelper.addObjNumber(b, btileId);
                if (showAxis)
                    b = VideoHelper.addAxisRectangle(b);
                bigBlocks[btileId] = b;
            }
            return bigBlocks;
        }

        //make capcom screen image
        public Bitmap makeScreen(int scrNo, int levelNo, int videoNo, int bigBlockNo, int blockNo, int palleteNo, float scale = 2.0f, bool withBorders = true)
        {
            if (scrNo < 0)
                return VideoHelper.emptyScreen((int)(ConfigScript.getScreenWidth(levelNo) * 32 * scale), (int)(ConfigScript.getScreenHeight(levelNo) * 32 * scale));
            var bigBlocks = makeBigBlocks(videoNo, bigBlockNo, blockNo, palleteNo, MapViewType.Tiles, scale, scale, MapViewType.Tiles, withBorders);
            //var bigBlocks = makeBigBlocks(videoNo, bigBlockNo, blockNo, palleteNo, MapViewType.ObjType, scale, scale,MapViewType.Tiles, withBorders);
            var il = new ImageList();
            if (bigBlocks.Length > 0)
            {
                il.ImageSize = bigBlocks[0].Size;
                il.Images.AddRange(bigBlocks);
            }
            int[] indexes = Globals.getScreen(ConfigScript.screensOffset[levelNo], scrNo);
            int scrW = ConfigScript.getScreenWidth(0); //zero as screenNoForLevel
            int scrH = ConfigScript.getScreenHeight(0);
            //capcom hardcode
            return new Bitmap(MapEditor.ScreenToImage(il, 32, 32, indexes, null, scale, true, false, false, 0, scrW, scrH, ConfigScript.getScreenVertical()));
        }

        public Color[] NesColors
        {
            get { return nesColors; }
            set { nesColors = value; }
        }

        private static int mixBits(bool hi, bool lo)
        {
            return (hi ? 1 : 0) << 1 | (lo ? 1 : 0);
        }

        public static int NES_COLORS_COUNT = 64;
        public static int CHUNK_COUNT = 256;
        public static Color[] nesColors = new Color[NES_COLORS_COUNT];

        const int CAD_OBJTYPES_COUNT = 16;
        public static Color[] CadObjectTypeColors = new Color[CAD_OBJTYPES_COUNT];
    }
}
