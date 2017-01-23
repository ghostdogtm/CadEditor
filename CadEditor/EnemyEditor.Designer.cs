﻿namespace CadEditor
{
    partial class EnemyEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnemyEditor));
            this.mapScreen = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.cbScreenNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lvObjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectSprites = new System.Windows.Forms.ImageList(this.components);
            this.cbCoordY = new System.Windows.Forms.ComboBox();
            this.cbCoordX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btClearObjs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.activeBlock = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btSortUp = new System.Windows.Forms.Button();
            this.btSortDown = new System.Windows.Forms.Button();
            this.pnGeneric = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.cbPlus256 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLayoutNo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaletteNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBlockNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBigBlockNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVideoNo = new System.Windows.Forms.ComboBox();
            this.pnSelectScreen = new System.Windows.Forms.Panel();
            this.lbScrNo = new System.Windows.Forms.Label();
            this.lbActive = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbReadOnly = new System.Windows.Forms.Label();
            this.pnTools = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbTool = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbObjType = new System.Windows.Forms.ComboBox();
            this.lbObjectsCount = new System.Windows.Forms.Label();
            this.pnView = new System.Windows.Forms.Panel();
            this.bigBlocks = new System.Windows.Forms.ImageList(this.components);
            this.pnObjectList = new System.Windows.Forms.Panel();
            this.pnDataGridViewObjects = new System.Windows.Forms.Panel();
            this.dgvObjects = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbObjectList = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btSort = new System.Windows.Forms.Button();
            this.pnAddData = new System.Windows.Forms.Panel();
            this.cbD4 = new System.Windows.Forms.ComboBox();
            this.lbD4 = new System.Windows.Forms.Label();
            this.cbD5 = new System.Windows.Forms.ComboBox();
            this.lbD5 = new System.Windows.Forms.Label();
            this.cbD2 = new System.Windows.Forms.ComboBox();
            this.lbD2 = new System.Windows.Forms.Label();
            this.cbD3 = new System.Windows.Forms.ComboBox();
            this.lbD3 = new System.Windows.Forms.Label();
            this.cbD0 = new System.Windows.Forms.ComboBox();
            this.lbD0 = new System.Windows.Forms.Label();
            this.cbD1 = new System.Windows.Forms.ComboBox();
            this.lbD1 = new System.Windows.Forms.Label();
            this.pnObjects = new System.Windows.Forms.Panel();
            this.btLoadJson = new System.Windows.Forms.Button();
            this.btSaveJson = new System.Windows.Forms.Button();
            this.pnBigObjects = new System.Windows.Forms.Panel();
            this.pbBigObject = new System.Windows.Forms.PictureBox();
            this.cbBigObjectNo = new System.Windows.Forms.ComboBox();
            this.cbUseBigPictures = new System.Windows.Forms.CheckBox();
            this.cbBindToAxis = new System.Windows.Forms.CheckBox();
            this.cbShowDataGrid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBlock)).BeginInit();
            this.pnGeneric.SuspendLayout();
            this.pnSelectScreen.SuspendLayout();
            this.pnTools.SuspendLayout();
            this.pnView.SuspendLayout();
            this.pnObjectList.SuspendLayout();
            this.pnDataGridViewObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).BeginInit();
            this.pnAddData.SuspendLayout();
            this.pnObjects.SuspendLayout();
            this.pnBigObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigObject)).BeginInit();
            this.SuspendLayout();
            // 
            // mapScreen
            // 
            this.mapScreen.Location = new System.Drawing.Point(0, 0);
            this.mapScreen.Margin = new System.Windows.Forms.Padding(4);
            this.mapScreen.Name = "mapScreen";
            this.mapScreen.Size = new System.Drawing.Size(683, 630);
            this.mapScreen.TabIndex = 30;
            this.mapScreen.TabStop = false;
            this.mapScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.mapScreen_Paint);
            this.mapScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseClick);
            this.mapScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseDown);
            this.mapScreen.MouseLeave += new System.EventHandler(this.mapScreen_MouseLeave);
            this.mapScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseMove);
            this.mapScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseUp);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(19, 26);
            this.btLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(71, 27);
            this.btLeft.TabIndex = 31;
            this.btLeft.Text = "←";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(165, 26);
            this.btRight.Margin = new System.Windows.Forms.Padding(4);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(71, 27);
            this.btRight.TabIndex = 32;
            this.btRight.Text = "→";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(92, 0);
            this.btUp.Margin = new System.Windows.Forms.Padding(4);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(71, 27);
            this.btUp.TabIndex = 33;
            this.btUp.Text = "↑";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(92, 62);
            this.btDown.Margin = new System.Windows.Forms.Padding(4);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(71, 27);
            this.btDown.TabIndex = 34;
            this.btDown.Text = "↓";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // cbScreenNo
            // 
            this.cbScreenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreenNo.FormattingEnabled = true;
            this.cbScreenNo.Location = new System.Drawing.Point(92, 28);
            this.cbScreenNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbScreenNo.Name = "cbScreenNo";
            this.cbScreenNo.Size = new System.Drawing.Size(69, 24);
            this.cbScreenNo.TabIndex = 35;
            this.cbScreenNo.SelectedIndexChanged += new System.EventHandler(this.cbScreenNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Screen No:";
            // 
            // objPanel
            // 
            this.objPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objPanel.AutoScroll = true;
            this.objPanel.Location = new System.Drawing.Point(5, 351);
            this.objPanel.Margin = new System.Windows.Forms.Padding(4);
            this.objPanel.Name = "objPanel";
            this.objPanel.Size = new System.Drawing.Size(229, 213);
            this.objPanel.TabIndex = 37;
            // 
            // lvObjects
            // 
            this.lvObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvObjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvObjects.Location = new System.Drawing.Point(0, 36);
            this.lvObjects.Margin = new System.Windows.Forms.Padding(4);
            this.lvObjects.Name = "lvObjects";
            this.lvObjects.Size = new System.Drawing.Size(307, 362);
            this.lvObjects.SmallImageList = this.objectSprites;
            this.lvObjects.TabIndex = 38;
            this.lvObjects.UseCompatibleStateImageBehavior = false;
            this.lvObjects.View = System.Windows.Forms.View.Details;
            this.lvObjects.SelectedIndexChanged += new System.EventHandler(this.lvObjects_SelectedIndexChanged);
            this.lvObjects.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbObjects_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 170;
            // 
            // objectSprites
            // 
            this.objectSprites.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.objectSprites.ImageSize = new System.Drawing.Size(16, 16);
            this.objectSprites.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbCoordY
            // 
            this.cbCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCoordY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoordY.DropDownWidth = 100;
            this.cbCoordY.Enabled = false;
            this.cbCoordY.FormattingEnabled = true;
            this.cbCoordY.Items.AddRange(new object[] {
            "Tiles",
            "Obj types"});
            this.cbCoordY.Location = new System.Drawing.Point(240, 400);
            this.cbCoordY.Margin = new System.Windows.Forms.Padding(4);
            this.cbCoordY.Name = "cbCoordY";
            this.cbCoordY.Size = new System.Drawing.Size(60, 24);
            this.cbCoordY.TabIndex = 42;
            this.cbCoordY.SelectedIndexChanged += new System.EventHandler(this.cbCoordX_SelectedIndexChanged);
            // 
            // cbCoordX
            // 
            this.cbCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCoordX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoordX.DropDownWidth = 100;
            this.cbCoordX.Enabled = false;
            this.cbCoordX.FormattingEnabled = true;
            this.cbCoordX.Items.AddRange(new object[] {
            "Tiles",
            "Obj types"});
            this.cbCoordX.Location = new System.Drawing.Point(140, 400);
            this.cbCoordX.Margin = new System.Windows.Forms.Padding(4);
            this.cbCoordX.Name = "cbCoordX";
            this.cbCoordX.Size = new System.Drawing.Size(60, 24);
            this.cbCoordX.TabIndex = 41;
            this.cbCoordX.SelectedIndexChanged += new System.EventHandler(this.cbCoordX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Type:";
            // 
            // btClearObjs
            // 
            this.btClearObjs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearObjs.Location = new System.Drawing.Point(127, 517);
            this.btClearObjs.Margin = new System.Windows.Forms.Padding(4);
            this.btClearObjs.Name = "btClearObjs";
            this.btClearObjs.Size = new System.Drawing.Size(184, 30);
            this.btClearObjs.TabIndex = 39;
            this.btClearObjs.Text = "clear all objects on screen";
            this.btClearObjs.UseVisualStyleBackColor = true;
            this.btClearObjs.Click += new System.EventHandler(this.btClearObjs_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 570);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Active:";
            // 
            // activeBlock
            // 
            this.activeBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeBlock.Location = new System.Drawing.Point(183, 570);
            this.activeBlock.Margin = new System.Windows.Forms.Padding(4);
            this.activeBlock.Name = "activeBlock";
            this.activeBlock.Size = new System.Drawing.Size(42, 39);
            this.activeBlock.TabIndex = 43;
            this.activeBlock.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(4, 565);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(97, 31);
            this.btSave.TabIndex = 45;
            this.btSave.Text = "save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSortUp
            // 
            this.btSortUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSortUp.Location = new System.Drawing.Point(127, 487);
            this.btSortUp.Margin = new System.Windows.Forms.Padding(4);
            this.btSortUp.Name = "btSortUp";
            this.btSortUp.Size = new System.Drawing.Size(88, 27);
            this.btSortUp.TabIndex = 47;
            this.btSortUp.Text = "↑";
            this.btSortUp.UseVisualStyleBackColor = true;
            this.btSortUp.Click += new System.EventHandler(this.btSortUp_Click);
            // 
            // btSortDown
            // 
            this.btSortDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSortDown.Location = new System.Drawing.Point(223, 487);
            this.btSortDown.Margin = new System.Windows.Forms.Padding(4);
            this.btSortDown.Name = "btSortDown";
            this.btSortDown.Size = new System.Drawing.Size(88, 27);
            this.btSortDown.TabIndex = 48;
            this.btSortDown.Text = "↓";
            this.btSortDown.UseVisualStyleBackColor = true;
            this.btSortDown.Click += new System.EventHandler(this.btSortDown_Click);
            // 
            // pnGeneric
            // 
            this.pnGeneric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGeneric.Controls.Add(this.label14);
            this.pnGeneric.Controls.Add(this.cbScale);
            this.pnGeneric.Controls.Add(this.cbPlus256);
            this.pnGeneric.Controls.Add(this.label11);
            this.pnGeneric.Controls.Add(this.cbLayoutNo);
            this.pnGeneric.Controls.Add(this.label9);
            this.pnGeneric.Controls.Add(this.cbPaletteNo);
            this.pnGeneric.Controls.Add(this.label8);
            this.pnGeneric.Controls.Add(this.cbBlockNo);
            this.pnGeneric.Controls.Add(this.label2);
            this.pnGeneric.Controls.Add(this.cbBigBlockNo);
            this.pnGeneric.Controls.Add(this.label4);
            this.pnGeneric.Controls.Add(this.cbVideoNo);
            this.pnGeneric.Location = new System.Drawing.Point(0, 10);
            this.pnGeneric.Margin = new System.Windows.Forms.Padding(4);
            this.pnGeneric.Name = "pnGeneric";
            this.pnGeneric.Size = new System.Drawing.Size(233, 164);
            this.pnGeneric.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Scale:";
            // 
            // cbScale
            // 
            this.cbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbScale.Location = new System.Drawing.Point(157, 81);
            this.cbScale.Margin = new System.Windows.Forms.Padding(4);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(59, 24);
            this.cbScale.TabIndex = 56;
            this.cbScale.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // cbPlus256
            // 
            this.cbPlus256.AutoSize = true;
            this.cbPlus256.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbPlus256.Location = new System.Drawing.Point(128, 5);
            this.cbPlus256.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlus256.Name = "cbPlus256";
            this.cbPlus256.Size = new System.Drawing.Size(98, 38);
            this.cbPlus256.TabIndex = 55;
            this.cbPlus256.Text = "+256 screens";
            this.cbPlus256.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Layout";
            // 
            // cbLayoutNo
            // 
            this.cbLayoutNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayoutNo.DropDownWidth = 220;
            this.cbLayoutNo.FormattingEnabled = true;
            this.cbLayoutNo.Items.AddRange(new object[] {
            "0x1DFA0 (17x4)",
            "0x1DFE4 (17x4)",
            "0x1E028 (17x4)",
            "0x1E0E4 (10x12)",
            "0x1E11D (19x3)",
            "0x1E06C (19x3)",
            "0x1E156  (19x3)"});
            this.cbLayoutNo.Location = new System.Drawing.Point(5, 20);
            this.cbLayoutNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbLayoutNo.Name = "cbLayoutNo";
            this.cbLayoutNo.Size = new System.Drawing.Size(113, 24);
            this.cbLayoutNo.TabIndex = 53;
            this.cbLayoutNo.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Pallete:";
            // 
            // cbPaletteNo
            // 
            this.cbPaletteNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteNo.FormattingEnabled = true;
            this.cbPaletteNo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbPaletteNo.Location = new System.Drawing.Point(11, 132);
            this.cbPaletteNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaletteNo.Name = "cbPaletteNo";
            this.cbPaletteNo.Size = new System.Drawing.Size(69, 24);
            this.cbPaletteNo.TabIndex = 47;
            this.cbPaletteNo.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Block:";
            // 
            // cbBlockNo
            // 
            this.cbBlockNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlockNo.FormattingEnabled = true;
            this.cbBlockNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbBlockNo.Location = new System.Drawing.Point(88, 130);
            this.cbBlockNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbBlockNo.Name = "cbBlockNo";
            this.cbBlockNo.Size = new System.Drawing.Size(59, 24);
            this.cbBlockNo.TabIndex = 45;
            this.cbBlockNo.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "BigBlock:";
            // 
            // cbBigBlockNo
            // 
            this.cbBigBlockNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBigBlockNo.FormattingEnabled = true;
            this.cbBigBlockNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbBigBlockNo.Location = new System.Drawing.Point(88, 81);
            this.cbBigBlockNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbBigBlockNo.Name = "cbBigBlockNo";
            this.cbBigBlockNo.Size = new System.Drawing.Size(59, 24);
            this.cbBigBlockNo.TabIndex = 43;
            this.cbBigBlockNo.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "VideoBlock:";
            // 
            // cbVideoNo
            // 
            this.cbVideoNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoNo.FormattingEnabled = true;
            this.cbVideoNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbVideoNo.Location = new System.Drawing.Point(8, 80);
            this.cbVideoNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVideoNo.Name = "cbVideoNo";
            this.cbVideoNo.Size = new System.Drawing.Size(72, 24);
            this.cbVideoNo.TabIndex = 41;
            this.cbVideoNo.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // pnSelectScreen
            // 
            this.pnSelectScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSelectScreen.Controls.Add(this.lbScrNo);
            this.pnSelectScreen.Controls.Add(this.label1);
            this.pnSelectScreen.Controls.Add(this.btLeft);
            this.pnSelectScreen.Controls.Add(this.btRight);
            this.pnSelectScreen.Controls.Add(this.btUp);
            this.pnSelectScreen.Controls.Add(this.btDown);
            this.pnSelectScreen.Controls.Add(this.cbScreenNo);
            this.pnSelectScreen.Location = new System.Drawing.Point(-7, 181);
            this.pnSelectScreen.Margin = new System.Windows.Forms.Padding(4);
            this.pnSelectScreen.Name = "pnSelectScreen";
            this.pnSelectScreen.Size = new System.Drawing.Size(237, 96);
            this.pnSelectScreen.TabIndex = 52;
            // 
            // lbScrNo
            // 
            this.lbScrNo.AutoSize = true;
            this.lbScrNo.Location = new System.Drawing.Point(171, 68);
            this.lbScrNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScrNo.Name = "lbScrNo";
            this.lbScrNo.Size = new System.Drawing.Size(18, 17);
            this.lbScrNo.TabIndex = 55;
            this.lbScrNo.Text = "()";
            // 
            // lbActive
            // 
            this.lbActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbActive.AutoSize = true;
            this.lbActive.Location = new System.Drawing.Point(121, 588);
            this.lbActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(18, 17);
            this.lbActive.TabIndex = 55;
            this.lbActive.Text = "()";
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(7, 517);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(116, 30);
            this.btDelete.TabIndex = 56;
            this.btDelete.Text = "delete selected";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 572);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Press CTRL or SHIFT to select many objects";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 493);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Objects order:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(893, 537);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 588);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 17);
            this.label13.TabIndex = 60;
            this.label13.Text = "Press DEL to delete selected objects";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 631);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 17);
            this.label15.TabIndex = 62;
            this.label15.Text = "Don\'t forget sort objects in right order";
            // 
            // lbReadOnly
            // 
            this.lbReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReadOnly.AutoSize = true;
            this.lbReadOnly.Location = new System.Drawing.Point(7, 574);
            this.lbReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReadOnly.Name = "lbReadOnly";
            this.lbReadOnly.Size = new System.Drawing.Size(88, 17);
            this.lbReadOnly.TabIndex = 63;
            this.lbReadOnly.Text = "READ ONLY";
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.label16);
            this.pnTools.Controls.Add(this.cbTool);
            this.pnTools.Location = new System.Drawing.Point(9, 292);
            this.pnTools.Margin = new System.Windows.Forms.Padding(4);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(237, 37);
            this.pnTools.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Tool:";
            // 
            // cbTool
            // 
            this.cbTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTool.FormattingEnabled = true;
            this.cbTool.Items.AddRange(new object[] {
            "Create",
            "Select",
            "Delete"});
            this.cbTool.Location = new System.Drawing.Point(64, 4);
            this.cbTool.Margin = new System.Windows.Forms.Padding(4);
            this.cbTool.Name = "cbTool";
            this.cbTool.Size = new System.Drawing.Size(164, 24);
            this.cbTool.TabIndex = 29;
            this.cbTool.SelectedIndexChanged += new System.EventHandler(this.cbTool_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(109, 404);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 17);
            this.label17.TabIndex = 64;
            this.label17.Text = "X:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(209, 404);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 17);
            this.label18.TabIndex = 65;
            this.label18.Text = "Y:";
            // 
            // cbObjType
            // 
            this.cbObjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjType.DropDownWidth = 100;
            this.cbObjType.Enabled = false;
            this.cbObjType.FormattingEnabled = true;
            this.cbObjType.Items.AddRange(new object[] {
            "Tiles",
            "Obj types"});
            this.cbObjType.Location = new System.Drawing.Point(40, 400);
            this.cbObjType.Margin = new System.Windows.Forms.Padding(4);
            this.cbObjType.Name = "cbObjType";
            this.cbObjType.Size = new System.Drawing.Size(60, 24);
            this.cbObjType.TabIndex = 66;
            this.cbObjType.SelectedIndexChanged += new System.EventHandler(this.cbCoordX_SelectedIndexChanged);
            // 
            // lbObjectsCount
            // 
            this.lbObjectsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbObjectsCount.AutoSize = true;
            this.lbObjectsCount.Location = new System.Drawing.Point(7, 551);
            this.lbObjectsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbObjectsCount.Name = "lbObjectsCount";
            this.lbObjectsCount.Size = new System.Drawing.Size(123, 17);
            this.lbObjectsCount.TabIndex = 67;
            this.lbObjectsCount.Text = "Objects count: 0/0";
            // 
            // pnView
            // 
            this.pnView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnView.AutoScroll = true;
            this.pnView.Controls.Add(this.mapScreen);
            this.pnView.Location = new System.Drawing.Point(264, 21);
            this.pnView.Margin = new System.Windows.Forms.Padding(4);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(683, 655);
            this.pnView.TabIndex = 68;
            // 
            // bigBlocks
            // 
            this.bigBlocks.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.bigBlocks.ImageSize = new System.Drawing.Size(64, 64);
            this.bigBlocks.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnObjectList
            // 
            this.pnObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnObjectList.Controls.Add(this.label6);
            this.pnObjectList.Controls.Add(this.cbObjectList);
            this.pnObjectList.Controls.Add(this.label19);
            this.pnObjectList.Controls.Add(this.btSort);
            this.pnObjectList.Controls.Add(this.pnAddData);
            this.pnObjectList.Controls.Add(this.lbObjectsCount);
            this.pnObjectList.Controls.Add(this.btClearObjs);
            this.pnObjectList.Controls.Add(this.cbObjType);
            this.pnObjectList.Controls.Add(this.label5);
            this.pnObjectList.Controls.Add(this.label18);
            this.pnObjectList.Controls.Add(this.cbCoordX);
            this.pnObjectList.Controls.Add(this.label17);
            this.pnObjectList.Controls.Add(this.cbCoordY);
            this.pnObjectList.Controls.Add(this.btSortUp);
            this.pnObjectList.Controls.Add(this.label15);
            this.pnObjectList.Controls.Add(this.btSortDown);
            this.pnObjectList.Controls.Add(this.btDelete);
            this.pnObjectList.Controls.Add(this.label13);
            this.pnObjectList.Controls.Add(this.label7);
            this.pnObjectList.Controls.Add(this.label10);
            this.pnObjectList.Controls.Add(this.lvObjects);
            this.pnObjectList.Controls.Add(this.pnDataGridViewObjects);
            this.pnObjectList.Location = new System.Drawing.Point(955, 57);
            this.pnObjectList.Margin = new System.Windows.Forms.Padding(4);
            this.pnObjectList.Name = "pnObjectList";
            this.pnObjectList.Size = new System.Drawing.Size(309, 623);
            this.pnObjectList.TabIndex = 31;
            // 
            // pnDataGridViewObjects
            // 
            this.pnDataGridViewObjects.Controls.Add(this.dgvObjects);
            this.pnDataGridViewObjects.Location = new System.Drawing.Point(0, 0);
            this.pnDataGridViewObjects.Name = "pnDataGridViewObjects";
            this.pnDataGridViewObjects.Size = new System.Drawing.Size(302, 393);
            this.pnDataGridViewObjects.TabIndex = 71;
            this.pnDataGridViewObjects.Visible = false;
            // 
            // dgvObjects
            // 
            this.dgvObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjects.Location = new System.Drawing.Point(3, 22);
            this.dgvObjects.Name = "dgvObjects";
            this.dgvObjects.RowTemplate.Height = 24;
            this.dgvObjects.Size = new System.Drawing.Size(302, 393);
            this.dgvObjects.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Object list:";
            // 
            // cbObjectList
            // 
            this.cbObjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectList.DropDownWidth = 220;
            this.cbObjectList.FormattingEnabled = true;
            this.cbObjectList.Location = new System.Drawing.Point(93, 4);
            this.cbObjectList.Margin = new System.Windows.Forms.Padding(4);
            this.cbObjectList.Name = "cbObjectList";
            this.cbObjectList.Size = new System.Drawing.Size(198, 24);
            this.cbObjectList.TabIndex = 58;
            this.cbObjectList.SelectedIndexChanged += new System.EventHandler(this.cbObjectList_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 603);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(265, 17);
            this.label19.TabIndex = 70;
            this.label19.Text = "Right click for dragging objects at screen";
            // 
            // btSort
            // 
            this.btSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSort.Location = new System.Drawing.Point(173, 544);
            this.btSort.Margin = new System.Windows.Forms.Padding(4);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(129, 30);
            this.btSort.TabIndex = 69;
            this.btSort.Text = "autosort objects";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // pnAddData
            // 
            this.pnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAddData.Controls.Add(this.cbD4);
            this.pnAddData.Controls.Add(this.lbD4);
            this.pnAddData.Controls.Add(this.cbD5);
            this.pnAddData.Controls.Add(this.lbD5);
            this.pnAddData.Controls.Add(this.cbD2);
            this.pnAddData.Controls.Add(this.lbD2);
            this.pnAddData.Controls.Add(this.cbD3);
            this.pnAddData.Controls.Add(this.lbD3);
            this.pnAddData.Controls.Add(this.cbD0);
            this.pnAddData.Controls.Add(this.lbD0);
            this.pnAddData.Controls.Add(this.cbD1);
            this.pnAddData.Controls.Add(this.lbD1);
            this.pnAddData.Location = new System.Drawing.Point(-4, 428);
            this.pnAddData.Margin = new System.Windows.Forms.Padding(4);
            this.pnAddData.Name = "pnAddData";
            this.pnAddData.Size = new System.Drawing.Size(305, 57);
            this.pnAddData.TabIndex = 68;
            // 
            // cbD4
            // 
            this.cbD4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD4.DropDownWidth = 100;
            this.cbD4.Enabled = false;
            this.cbD4.FormattingEnabled = true;
            this.cbD4.Items.AddRange(new object[] {
            "\\"});
            this.cbD4.Location = new System.Drawing.Point(144, 30);
            this.cbD4.Margin = new System.Windows.Forms.Padding(4);
            this.cbD4.Name = "cbD4";
            this.cbD4.Size = new System.Drawing.Size(60, 24);
            this.cbD4.TabIndex = 79;
            // 
            // lbD4
            // 
            this.lbD4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD4.AutoSize = true;
            this.lbD4.Location = new System.Drawing.Point(107, 33);
            this.lbD4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD4.Name = "lbD4";
            this.lbD4.Size = new System.Drawing.Size(30, 17);
            this.lbD4.TabIndex = 78;
            this.lbD4.Text = "D1:";
            // 
            // cbD5
            // 
            this.cbD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD5.DropDownWidth = 100;
            this.cbD5.Enabled = false;
            this.cbD5.FormattingEnabled = true;
            this.cbD5.Items.AddRange(new object[] {
            "\\"});
            this.cbD5.Location = new System.Drawing.Point(244, 30);
            this.cbD5.Margin = new System.Windows.Forms.Padding(4);
            this.cbD5.Name = "cbD5";
            this.cbD5.Size = new System.Drawing.Size(60, 24);
            this.cbD5.TabIndex = 77;
            // 
            // lbD5
            // 
            this.lbD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD5.AutoSize = true;
            this.lbD5.Location = new System.Drawing.Point(208, 33);
            this.lbD5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD5.Name = "lbD5";
            this.lbD5.Size = new System.Drawing.Size(30, 17);
            this.lbD5.TabIndex = 76;
            this.lbD5.Text = "D1:";
            // 
            // cbD2
            // 
            this.cbD2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD2.DropDownWidth = 100;
            this.cbD2.Enabled = false;
            this.cbD2.FormattingEnabled = true;
            this.cbD2.Items.AddRange(new object[] {
            "\\"});
            this.cbD2.Location = new System.Drawing.Point(244, 4);
            this.cbD2.Margin = new System.Windows.Forms.Padding(4);
            this.cbD2.Name = "cbD2";
            this.cbD2.Size = new System.Drawing.Size(60, 24);
            this.cbD2.TabIndex = 75;
            // 
            // lbD2
            // 
            this.lbD2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD2.AutoSize = true;
            this.lbD2.Location = new System.Drawing.Point(207, 7);
            this.lbD2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD2.Name = "lbD2";
            this.lbD2.Size = new System.Drawing.Size(30, 17);
            this.lbD2.TabIndex = 74;
            this.lbD2.Text = "D1:";
            // 
            // cbD3
            // 
            this.cbD3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD3.DropDownWidth = 100;
            this.cbD3.Enabled = false;
            this.cbD3.FormattingEnabled = true;
            this.cbD3.Items.AddRange(new object[] {
            "\\"});
            this.cbD3.Location = new System.Drawing.Point(44, 30);
            this.cbD3.Margin = new System.Windows.Forms.Padding(4);
            this.cbD3.Name = "cbD3";
            this.cbD3.Size = new System.Drawing.Size(60, 24);
            this.cbD3.TabIndex = 73;
            // 
            // lbD3
            // 
            this.lbD3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD3.AutoSize = true;
            this.lbD3.Location = new System.Drawing.Point(4, 33);
            this.lbD3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD3.Name = "lbD3";
            this.lbD3.Size = new System.Drawing.Size(30, 17);
            this.lbD3.TabIndex = 72;
            this.lbD3.Text = "D1:";
            // 
            // cbD0
            // 
            this.cbD0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD0.DropDownWidth = 100;
            this.cbD0.Enabled = false;
            this.cbD0.FormattingEnabled = true;
            this.cbD0.Items.AddRange(new object[] {
            "\\"});
            this.cbD0.Location = new System.Drawing.Point(44, 4);
            this.cbD0.Margin = new System.Windows.Forms.Padding(4);
            this.cbD0.Name = "cbD0";
            this.cbD0.Size = new System.Drawing.Size(60, 24);
            this.cbD0.TabIndex = 71;
            // 
            // lbD0
            // 
            this.lbD0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD0.AutoSize = true;
            this.lbD0.Location = new System.Drawing.Point(4, 7);
            this.lbD0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD0.Name = "lbD0";
            this.lbD0.Size = new System.Drawing.Size(30, 17);
            this.lbD0.TabIndex = 70;
            this.lbD0.Text = "D1:";
            // 
            // cbD1
            // 
            this.cbD1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD1.DropDownWidth = 100;
            this.cbD1.Enabled = false;
            this.cbD1.FormattingEnabled = true;
            this.cbD1.Items.AddRange(new object[] {
            "\\"});
            this.cbD1.Location = new System.Drawing.Point(144, 4);
            this.cbD1.Margin = new System.Windows.Forms.Padding(4);
            this.cbD1.Name = "cbD1";
            this.cbD1.Size = new System.Drawing.Size(60, 24);
            this.cbD1.TabIndex = 69;
            // 
            // lbD1
            // 
            this.lbD1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD1.AutoSize = true;
            this.lbD1.Location = new System.Drawing.Point(107, 7);
            this.lbD1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD1.Name = "lbD1";
            this.lbD1.Size = new System.Drawing.Size(30, 17);
            this.lbD1.TabIndex = 68;
            this.lbD1.Text = "D1:";
            // 
            // pnObjects
            // 
            this.pnObjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnObjects.Controls.Add(this.btLoadJson);
            this.pnObjects.Controls.Add(this.btSaveJson);
            this.pnObjects.Controls.Add(this.pnBigObjects);
            this.pnObjects.Controls.Add(this.cbUseBigPictures);
            this.pnObjects.Controls.Add(this.cbBindToAxis);
            this.pnObjects.Controls.Add(this.objPanel);
            this.pnObjects.Controls.Add(this.activeBlock);
            this.pnObjects.Controls.Add(this.lbReadOnly);
            this.pnObjects.Controls.Add(this.label3);
            this.pnObjects.Controls.Add(this.btSave);
            this.pnObjects.Controls.Add(this.lbActive);
            this.pnObjects.Controls.Add(this.pnGeneric);
            this.pnObjects.Controls.Add(this.pnSelectScreen);
            this.pnObjects.Location = new System.Drawing.Point(12, 7);
            this.pnObjects.Margin = new System.Windows.Forms.Padding(4);
            this.pnObjects.Name = "pnObjects";
            this.pnObjects.Size = new System.Drawing.Size(244, 672);
            this.pnObjects.TabIndex = 31;
            // 
            // btLoadJson
            // 
            this.btLoadJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadJson.Location = new System.Drawing.Point(120, 630);
            this.btLoadJson.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadJson.Name = "btLoadJson";
            this.btLoadJson.Size = new System.Drawing.Size(108, 42);
            this.btLoadJson.TabIndex = 67;
            this.btLoadJson.Text = "load test.json";
            this.btLoadJson.UseVisualStyleBackColor = true;
            this.btLoadJson.Click += new System.EventHandler(this.btLoadJson_Click);
            // 
            // btSaveJson
            // 
            this.btSaveJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveJson.Location = new System.Drawing.Point(3, 630);
            this.btSaveJson.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveJson.Name = "btSaveJson";
            this.btSaveJson.Size = new System.Drawing.Size(109, 42);
            this.btSaveJson.TabIndex = 66;
            this.btSaveJson.Text = "save test.json";
            this.btSaveJson.UseVisualStyleBackColor = true;
            this.btSaveJson.Click += new System.EventHandler(this.btSaveJson_Click);
            // 
            // pnBigObjects
            // 
            this.pnBigObjects.Controls.Add(this.pbBigObject);
            this.pnBigObjects.Controls.Add(this.cbBigObjectNo);
            this.pnBigObjects.Location = new System.Drawing.Point(7, 342);
            this.pnBigObjects.Margin = new System.Windows.Forms.Padding(4);
            this.pnBigObjects.Name = "pnBigObjects";
            this.pnBigObjects.Size = new System.Drawing.Size(228, 215);
            this.pnBigObjects.TabIndex = 31;
            this.pnBigObjects.Visible = false;
            // 
            // pbBigObject
            // 
            this.pbBigObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBigObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBigObject.Location = new System.Drawing.Point(1, 37);
            this.pbBigObject.Margin = new System.Windows.Forms.Padding(4);
            this.pbBigObject.Name = "pbBigObject";
            this.pbBigObject.Size = new System.Drawing.Size(94, 82);
            this.pbBigObject.TabIndex = 66;
            this.pbBigObject.TabStop = false;
            // 
            // cbBigObjectNo
            // 
            this.cbBigObjectNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBigObjectNo.FormattingEnabled = true;
            this.cbBigObjectNo.Location = new System.Drawing.Point(1, 9);
            this.cbBigObjectNo.Margin = new System.Windows.Forms.Padding(4);
            this.cbBigObjectNo.Name = "cbBigObjectNo";
            this.cbBigObjectNo.Size = new System.Drawing.Size(96, 24);
            this.cbBigObjectNo.TabIndex = 30;
            this.cbBigObjectNo.SelectedIndexChanged += new System.EventHandler(this.cbBigObjectNo_SelectedIndexChanged);
            // 
            // cbUseBigPictures
            // 
            this.cbUseBigPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseBigPictures.AutoSize = true;
            this.cbUseBigPictures.Location = new System.Drawing.Point(7, 322);
            this.cbUseBigPictures.Margin = new System.Windows.Forms.Padding(4);
            this.cbUseBigPictures.Name = "cbUseBigPictures";
            this.cbUseBigPictures.Size = new System.Drawing.Size(128, 21);
            this.cbUseBigPictures.TabIndex = 65;
            this.cbUseBigPictures.Text = "Alternative view";
            this.cbUseBigPictures.UseVisualStyleBackColor = true;
            this.cbUseBigPictures.CheckedChanged += new System.EventHandler(this.cbUseBigPictures_CheckedChanged);
            // 
            // cbBindToAxis
            // 
            this.cbBindToAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBindToAxis.AutoSize = true;
            this.cbBindToAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBindToAxis.Location = new System.Drawing.Point(85, 613);
            this.cbBindToAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbBindToAxis.Name = "cbBindToAxis";
            this.cbBindToAxis.Size = new System.Drawing.Size(137, 21);
            this.cbBindToAxis.TabIndex = 64;
            this.cbBindToAxis.Text = "Align per 8 pixels";
            this.cbBindToAxis.UseVisualStyleBackColor = true;
            this.cbBindToAxis.CheckedChanged += new System.EventHandler(this.cbBindToAxis_CheckedChanged);
            // 
            // cbShowDataGrid
            // 
            this.cbShowDataGrid.AutoSize = true;
            this.cbShowDataGrid.Location = new System.Drawing.Point(958, 22);
            this.cbShowDataGrid.Name = "cbShowDataGrid";
            this.cbShowDataGrid.Size = new System.Drawing.Size(129, 21);
            this.cbShowDataGrid.TabIndex = 69;
            this.cbShowDataGrid.Text = "Show Data Grid";
            this.cbShowDataGrid.UseVisualStyleBackColor = true;
            this.cbShowDataGrid.Visible = false;
            // 
            // EnemyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 681);
            this.Controls.Add(this.cbShowDataGrid);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnObjects);
            this.Controls.Add(this.pnObjectList);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnemyEditor";
            this.Text = "Enemy Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnemyEditor_FormClosing);
            this.Load += new System.EventHandler(this.EnemyEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBlock)).EndInit();
            this.pnGeneric.ResumeLayout(false);
            this.pnGeneric.PerformLayout();
            this.pnSelectScreen.ResumeLayout(false);
            this.pnSelectScreen.PerformLayout();
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.pnView.ResumeLayout(false);
            this.pnObjectList.ResumeLayout(false);
            this.pnObjectList.PerformLayout();
            this.pnDataGridViewObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).EndInit();
            this.pnAddData.ResumeLayout(false);
            this.pnAddData.PerformLayout();
            this.pnObjects.ResumeLayout(false);
            this.pnObjects.PerformLayout();
            this.pnBigObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBigObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapScreen;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.ComboBox cbScreenNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel objPanel;
        private System.Windows.Forms.ListView lvObjects;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbCoordY;
        private System.Windows.Forms.ComboBox cbCoordX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClearObjs;
        private System.Windows.Forms.ImageList objectSprites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox activeBlock;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSortUp;
        private System.Windows.Forms.Button btSortDown;
        private System.Windows.Forms.Panel pnGeneric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLayoutNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPaletteNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBlockNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBigBlockNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVideoNo;
        private System.Windows.Forms.Panel pnSelectScreen;
        private System.Windows.Forms.Label lbScrNo;
        private System.Windows.Forms.CheckBox cbPlus256;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbReadOnly;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbTool;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbObjType;
        private System.Windows.Forms.Label lbObjectsCount;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.ImageList bigBlocks;
        private System.Windows.Forms.Panel pnObjectList;
        private System.Windows.Forms.Panel pnObjects;
        private System.Windows.Forms.Panel pnAddData;
        private System.Windows.Forms.ComboBox cbD1;
        private System.Windows.Forms.Label lbD1;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbD4;
        private System.Windows.Forms.Label lbD4;
        private System.Windows.Forms.ComboBox cbD5;
        private System.Windows.Forms.Label lbD5;
        private System.Windows.Forms.ComboBox cbD2;
        private System.Windows.Forms.Label lbD2;
        private System.Windows.Forms.ComboBox cbD3;
        private System.Windows.Forms.Label lbD3;
        private System.Windows.Forms.ComboBox cbD0;
        private System.Windows.Forms.Label lbD0;
        private System.Windows.Forms.CheckBox cbBindToAxis;
        private System.Windows.Forms.CheckBox cbUseBigPictures;
        private System.Windows.Forms.Panel pnBigObjects;
        private System.Windows.Forms.PictureBox pbBigObject;
        private System.Windows.Forms.ComboBox cbBigObjectNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbScale;
        private System.Windows.Forms.Button btLoadJson;
        private System.Windows.Forms.Button btSaveJson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbObjectList;
        private System.Windows.Forms.Panel pnDataGridViewObjects;
        private System.Windows.Forms.DataGridView dgvObjects;
        private System.Windows.Forms.CheckBox cbShowDataGrid;
    }
}