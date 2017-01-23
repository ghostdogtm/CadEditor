﻿using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace CadEditor
{
    public static class UtilsGui
    {
        public static void setCbItemsCount(ComboBox cb, int count, int first = 0, bool inHex = false)
        {
            cb.Items.Clear();
            if (!inHex)
            {
                for (int i = 0; i < count; i++)
                    cb.Items.Add(first + i);
            }
            else
            {
                for (int i = 0; i < count; i++)
                    cb.Items.Add(String.Format("{0:X}", first + i));
            }
        }

        public static void setCbIndexWithoutUpdateLevel(ComboBox cb, EventHandler ev, int index = 0)
        {
            cb.SelectedIndexChanged -= ev;
            cb.SelectedIndex = index;
            cb.SelectedIndexChanged += ev;
        }

        public static void setCbCheckedWithoutUpdateLevel(CheckBox cb, EventHandler ev, bool index = false)
        {
            cb.CheckedChanged -= ev;
            cb.Checked = index;
            cb.CheckedChanged += ev;
        }

        public static void prepareBlocksPanel(FlowLayoutPanel blocksPanel, Size buttonSize, ImageList buttonsImages, EventHandler buttonBlockClick, int startIndex, int count)
        {
            blocksPanel.Controls.Clear();
            blocksPanel.SuspendLayout();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                var but = new Button();
                but.FlatStyle = FlatStyle.Flat;
                but.Size = buttonSize;
                but.ImageList = buttonsImages;
                but.ImageIndex = i;
                but.Click += buttonBlockClick;
                but.Margin = new Padding(0);
                but.Padding = new Padding(0);
                blocksPanel.Controls.Add(but);
            }
            blocksPanel.ResumeLayout();
        }

        public static void reloadBlocksPanel(FlowLayoutPanel blocksPanel, ImageList buttonsImages, int startIndex, int count)
        {
            for (int i = startIndex, controlIndex = 0; i < startIndex + count; i++, controlIndex++)
            {
                var but = (Button)blocksPanel.Controls[controlIndex];
                but.ImageList = buttonsImages;
                but.ImageIndex = i;
            }
        }

        public delegate bool SaveFunction();
        public delegate void ReturnComboBoxIndexFunction();
        public static bool askToSave(ref bool dirty, SaveFunction saveToFile, ReturnComboBoxIndexFunction returnCbLevelIndex)
        {
            if (!dirty)
                return true;
            DialogResult dr = MessageBox.Show("Level was changed. Do you want to save current level?", "Save", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel)
            {
                if (returnCbLevelIndex != null)
                    returnCbLevelIndex();
                return false;
            }
            else if (dr == DialogResult.Yes)
            {
                if (!saveToFile())
                {
                    if (returnCbLevelIndex != null)
                        returnCbLevelIndex();
                    return false;
                }
                return true;
            }
            else
            {
                dirty = false;
                return true;
            }
        }

        public static Rectangle getVisibleRectangle(Control panel, Control insideControl)
        {
            Rectangle rect = panel.RectangleToScreen(panel.ClientRectangle);
            while (panel != null)
            {
                rect = Rectangle.Intersect(rect, panel.RectangleToScreen(panel.ClientRectangle));
                panel = panel.Parent;
            }
            rect = insideControl.RectangleToClient(rect);
            return rect;
        }
    }
}
