﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace CadEditor
{
    public partial class BigBlockEdit : Form
    {
        public BigBlockEdit()
        {
            InitializeComponent();
        }

        private void BigBlockEdit_Load(object sender, EventArgs e)
        {
            curTileset = 0;
            curVideo = 0x90;
            curPallete = 0;
            curPart = 0;
            dirty = false;
            updateSaveVisibility();
            curViewType = MapViewType.Tiles;

            initControls();
        
            blocksPanel.Controls.Clear();
            blocksPanel.SuspendLayout();
            for (int i = 0; i < SMALL_BLOCKS_COUNT; i++)
            {
                var but = new Button();
                but.FlatStyle = FlatStyle.Flat;
                but.Size = new Size(32, 32);
                but.ImageList = smallBlocks;
                but.ImageIndex = i;
                but.Margin = new Padding(0);
                but.Padding = new Padding(0);
                but.Click += new EventHandler(buttonObjClick);
                blocksPanel.Controls.Add(but);
            }
            blocksPanel.ResumeLayout();
 
            reloadLevel();

            readOnly = false; //must be read from config
            tbbSave.Enabled = !readOnly;
            tbbImport.Enabled = !readOnly;
        }

        protected virtual void initControls()
        {
            Utils.setCbItemsCount(cbVideoNo, ConfigScript.videoOffset.recCount);
            Utils.setCbItemsCount(cbSmallBlock, ConfigScript.blocksOffset.recCount);
            Utils.setCbItemsCount(cbPaletteNo, ConfigScript.palOffset.recCount);
            Utils.setCbItemsCount(cbPart, Math.Max(ConfigScript.getBigBlocksCount() / 256, 1));
            cbTileset.Items.Clear();
            for (int i = 0; i < ConfigScript.bigBlocksOffset.recCount; i++)
            {
                var str = String.Format("Tileset{0}", i);
                cbTileset.Items.Add(str);
            }

            //generic version
            cbTileset.SelectedIndex = formMain.CurActiveBigBlockNo;
            cbVideoNo.SelectedIndex = formMain.CurActiveVideoNo - 0x90;
            cbSmallBlock.SelectedIndex = formMain.CurActiveBlockNo;
            cbPaletteNo.SelectedIndex = formMain.CurActivePalleteNo;
            cbPart.SelectedIndex = 0;
            cbViewType.SelectedIndex = Math.Min((int)formMain.CurActiveViewType, cbViewType.Items.Count - 1);
        }

        protected void reloadLevel(bool reloadBigBlocks = true)
        {
            curActiveBlock = 0;
            if (reloadBigBlocks)
              setBigBlocksIndexes();
            setSmallBlocks();
            mapScreen.Invalidate();
        }

        protected virtual void setSmallBlocks()
        {
            int backId, palId;
            backId = curVideo;
            palId = curPallete;

            var im = ConfigScript.videoNes.makeObjectsStrip((byte)backId, (byte)curTileset, (byte)palId, 1, curViewType);
            smallBlocks.Images.Clear();
            smallBlocks.Images.AddStrip(im);
            blocksPanel.Invalidate(true);

            //prerender big blocks
            bigBlocksImages = ConfigScript.videoNes.makeBigBlocks(backId, curTileset, bigBlockIndexes, palId, curViewType, 1, 2.0f, MapViewType.Tiles, false);
            //
            int btc = Math.Min(ConfigScript.getBigBlocksCount(), 256);
            int bblocksInRow = 16;
            int bblocksInCol = (btc / bblocksInRow) + 1;
            //
            mapScreen.Size = new Size(bigBlocksImages[0].Width* bblocksInRow, bigBlocksImages[0].Height*bblocksInCol);
        }

        protected virtual void setBigBlocksIndexes()
        {
            bigBlockIndexes = ConfigScript.getBigBlocks(curSmallBlockNo);
        }

        protected virtual void exportBlocks()
        {
            //duck tales 2 has other format
            var f = new SelectFile();
            f.Filename = "exportedBigBlocks.bin";
            f.ShowExportParams = true;
            f.ShowDialog();
            if (!f.Result)
                return;
            var fn = f.Filename;
            if (f.getExportType() == ExportType.Binary)
            {
                Utils.saveDataToFile(fn, Utils.linearizeBigBlocks(bigBlockIndexes));
            }
            else
            {
                Bitmap result = new Bitmap((int)(32 * formMain.CurScale * 256),(int)(32 * formMain.CurScale)); //need some hack for duck tales 1
                Image[][] smallBlocksPack = new Image[1][];
                smallBlocksPack[0] = smallBlocks.Images.Cast<Image>().ToArray();
                using (Graphics g = Graphics.FromImage(result))
                {
                    for (int i = 0; i < ConfigScript.getBigBlocksCount(); i++)
                    {
                        Bitmap b;
                        b = ConfigScript.videoNes.makeBigBlock(i, bigBlockIndexes, smallBlocksPack);
                        g.DrawImage(b, new Point((int)(32 * formMain.CurScale * i), 0));
                    }
                }
                result.Save(fn);
            }
        }

        protected int SMALL_BLOCKS_COUNT = 256;
        protected BigBlock[] bigBlockIndexes;

        //hardcode
        private int getBlockWidth()
        {
            return 16;
        }

        private int getBlockHeight()
        {
            return 16;
        }

        protected void mapScreen_Paint(object sender, PaintEventArgs e)
        {
            int addIndexes = curPart * 256;
            Graphics g = e.Graphics;
            int btc = Math.Min(ConfigScript.getBigBlocksCount(), 256);
            int bblocksInRow = 16;
            int bblocksInCol = (btc / bblocksInRow) + 1;

            var testBBlock = bigBlockIndexes[0];
            int bWidth = getBlockWidth();
            int bHeight = getBlockHeight();
            int bbWidth  =  bWidth  * testBBlock.width;
            int bbHeight =  bHeight * testBBlock.height;

            var pen = new Pen(Brushes.Magenta);

            for (int i = 0; i < btc; i++)
            {
                int xb = i % bblocksInRow;
                int yb = i / bblocksInRow;
                /*var bb = bigBlockIndexes[addIndexes+i];
                for (int h = 0; h < bb.height; h++)
                {
                    for (int w = 0; w < bb.height; w++)
                    {
                        int sbX = w * bWidth;
                        int sbY = h * bHeight;
                        int idx = h * bb.width + w;
                        var r =  new Rectangle(xb * bbWidth + sbX, yb * bbHeight + sbY, bWidth, bHeight);
                        g.DrawImage(smallBlocks.Images[bb.indexes[idx]], r);
                    }
                }*/
                var rr = new Rectangle(xb * bbWidth, yb * bbHeight, bbWidth, bbHeight);
                g.DrawImage(bigBlocksImages[addIndexes + i], rr);

                g.DrawRectangle(pen, rr);
            }
        }

        protected void mapScreen_MouseClick(object sender, MouseEventArgs e)
        {
            int addIndexes = curPart * 256;
            dirty = true; updateSaveVisibility();

            int btc = Math.Min(ConfigScript.getBigBlocksCount(), 256);
            int bblocksInRow = 16;
            int bblocksInCol = (btc / bblocksInRow) + 1;

            var testBBlock = bigBlockIndexes[0];
            int bWidth = getBlockWidth();
            int bHeight = getBlockHeight();
            int bbWidth  =  bWidth  * testBBlock.width;
            int bbHeight =  bHeight * testBBlock.height;

            int bx = e.X / bbWidth;
            int by = e.Y / bbHeight;
            int dx = (e.X % bbWidth) / bWidth;
            int dy = (e.Y % bbHeight) / bHeight;
            int bigBlockIndex = by * bblocksInRow + bx;
            int insideIndex   = dy * testBBlock.width + dx;
            //prevent out in bounds
            if (bigBlockIndex >= btc)
            {
                return;
            }
            int actualIndex = addIndexes + bigBlockIndex;
            if (e.Button == MouseButtons.Left)
            {
                if (actualIndex < bigBlockIndexes.Length)
                    bigBlockIndexes[actualIndex].indexes[insideIndex] = curActiveBlock;
                mapScreen.Invalidate();
            }
            else
            {
                if (actualIndex < bigBlockIndexes.Length)
                    curActiveBlock = bigBlockIndexes[actualIndex].indexes[insideIndex];
                pbActive.Image = smallBlocks.Images[curActiveBlock];
                lbActive.Text = String.Format("({0:X})", curActiveBlock);
            }
            //fix current big blocks image
            var imss = new Image[1][] { smallBlocks.Images.Cast<Image>().ToArray() };
            bigBlocksImages[actualIndex] = ConfigScript.videoNes.makeBigBlock(actualIndex, bigBlockIndexes, imss);
        }

        protected void buttonObjClick(Object button, EventArgs e)
        {
            int index = ((Button)button).ImageIndex;
            pbActive.Image = smallBlocks.Images[index];
            lbActive.Text = String.Format("({0:X})", curActiveBlock);
            curActiveBlock = index;
        }

        protected int curActiveBlock;
        protected int curTileset;
        protected int curSmallBlockNo;

        //generic
        protected int curVideo;
        protected int curPallete;
        protected int curPart;

        protected MapViewType curViewType;

        protected bool dirty;
        protected bool readOnly;

        protected FormMain formMain;

        Image[] bigBlocksImages; //prerendered for faster rendering;

        protected void updateSaveVisibility()
        {
            tbbSave.Enabled = dirty;
        }

        private void cbLevelPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (
                cbTileset.SelectedIndex == -1 ||
                cbVideoNo.SelectedIndex == -1 || 
                cbPaletteNo.SelectedIndex == -1 ||
                cbPart.SelectedIndex == -1 ||
                cbViewType.SelectedIndex == -1 || 
                cbSmallBlock.SelectedIndex == -1
                )
            {
                return;
            }
            if (!readOnly && dirty && sender == cbTileset)
            {
                DialogResult dr = MessageBox.Show("Tiles was changed. Do you want to save current tileset?", "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                {
                    returnCbLevelIndexes();
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    if (!saveToFile())
                    {
                        returnCbLevelIndexes();
                        return;
                    }
                }
                else
                {
                    dirty = false;
                    updateSaveVisibility();
                }
            }

            //generic version
            curTileset = cbTileset.SelectedIndex;
            curSmallBlockNo = cbSmallBlock.SelectedIndex;
            curViewType = (MapViewType)cbViewType.SelectedIndex;

            curVideo = cbVideoNo.SelectedIndex + 0x90;
            curPallete = cbPaletteNo.SelectedIndex;
            curPart = cbPart.SelectedIndex;
            Utils.setCbItemsCount(cbPart, Math.Max(ConfigScript.getBigBlocksCount() / 256, 1));
            Utils.setCbIndexWithoutUpdateLevel(cbPart, cbLevelPair_SelectedIndexChanged, curPart);
            reloadLevel();
        }

        private void returnCbLevelIndexes()
        {
            cbTileset.SelectedIndexChanged -= cbLevelPair_SelectedIndexChanged;
            cbTileset.SelectedIndex = curTileset;
            cbTileset.SelectedIndexChanged += cbLevelPair_SelectedIndexChanged;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        protected bool saveToFile()
        {
            ConfigScript.setBigBlocks(curSmallBlockNo, bigBlockIndexes);
            dirty = !Globals.flushToFile();
            updateSaveVisibility();
            return !dirty;
        }

        protected void BigBlockEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!readOnly && dirty)
            {
                DialogResult dr = MessageBox.Show("Tiles was changed. Do you want to save current tileset?", "Save", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    saveToFile();
            }
        }

        protected void btClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to clear all blocks?", "Clear", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            for (int i = 0; i < bigBlockIndexes.Length; i++)
            {
                var bb = bigBlockIndexes[i];
                for (int j = 0; j < bb.indexes.Length; j++)
                {
                    bb.indexes[j] = 0;
                }
            }
            dirty = true;
            updateSaveVisibility();
            mapScreen.Invalidate();
        }

        protected void btExport_Click(object sender, EventArgs e)
        {
            exportBlocks();
        }

        protected void btImport_Click(object sender, EventArgs e)
        {
            var f = new SelectFile();
            f.Filename = "exportedBigBlocks.bin";
            f.ShowDialog();
            if (!f.Result)
                return;
            var fn = f.Filename;
            var data = Utils.loadDataFromFile(fn);
            //duck tales 2 has other format
            bigBlockIndexes = Utils.unlinearizeBigBlocks(data, 2,2);
            reloadLevel(false);
            dirty = true;
            updateSaveVisibility();
        }

        public void setFormMain(FormMain f)
        {
            formMain = f;
        }

        protected void mapScreen_MouseMove(object sender, MouseEventArgs e)
        {
            int addIndexesText = curPart * 256;

            int btc = Math.Min(ConfigScript.getBigBlocksCount(), 256);
            int bblocksInRow = 16;
            int bblocksInCol = (btc / bblocksInRow) + 1;

            var testBBlock = bigBlockIndexes[0];
            int bWidth = getBlockWidth();
            int bHeight = getBlockHeight();
            int bbWidth  =  bWidth  * testBBlock.width;
            int bbHeight =  bHeight * testBBlock.height;

            int bx = e.X / bbWidth;
            int by = e.Y / bbHeight;
            int dx = (e.X % bbWidth) / bWidth;
            int dy = (e.Y % bbHeight) / bHeight;
            int ind = ((by * bblocksInRow + bx) * testBBlock.getSize() + (dy * testBBlock.width + dx)) / testBBlock.getSize();
            if (ind > 255)
            {
                lbBigBlockNo.Text = "()";
            }
            else
            {
                int actualIndex = addIndexesText + ind;
                lbBigBlockNo.Text = String.Format("({0:X})", actualIndex);
            }
        }

        protected void mapScreen_MouseLeave(object sender, EventArgs e)
        {
            lbBigBlockNo.Text = "()";
        }
    }
}
