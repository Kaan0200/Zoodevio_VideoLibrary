﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class GridViewControl : UserControl
    {
        private List<ListViewItem> fullList = new List<ListViewItem>();

        public FileManager Manager;

        public GridViewControl()
        {
            InitializeComponent();

            // this is the default, set it so we know for certain
            gridView.View = View.LargeIcon;

            // add the columns to the gridView
            var fileNameColumn = new ColumnHeader("File")
            {
                Text = "File",
                Width = 200
            };
            var extensionColumn = new ColumnHeader("Extension")
            {
                Text = "ext",
                Width = 50
            };
            var lengthColumn = new ColumnHeader("FrameRate")
            {
                Text = "Framerate",
                Width = 60
            };
            gridView.Columns.Add(fileNameColumn);
            gridView.Columns.Add(extensionColumn);
            gridView.Columns.Add(lengthColumn);

            // disable the icon view since we are already there
            iconViewButton.Enabled = false;
        }
        
        // Clear all controls
        public void ClearView()
        {
            gridView.Items.Clear();
            fullList.Clear();
        }

        internal void CreateVideoIcon(VideoFile f)
        {
            string[] paths = f.Path.Split(Convert.ToChar("\\"));
            string name = paths[paths.Length - 1];
            var item = new ListViewItem
            {
                Name = name,
                Text = name,
                Tag = f,//f.Path,
                BackColor = Color.Azure,
                SubItems =
                { //TODO: get time working, it doesn't want to parse
                    f.Tags.Find(t => (Tags.GetTagType(t.TypeId).Name == "file_type")).Data,
                    f.Tags.Find(t => (Tags.GetTagType(t.TypeId).Name == "framerate")).Data
                }
            };
            fullList.Add(item);
            gridView.Items.Add(item);
        }

        private void changeToIcon_Click(object sender, EventArgs e)
        {
            // toggle the button enables
            iconViewButton.Enabled = false;
            listViewButton.Enabled = true;
            // switch the view type
            gridView.View = View.LargeIcon;
        }

        private void changeToList_Click(object sender, EventArgs e)
        {
            // toggle the button enables
            iconViewButton.Enabled = true;
            listViewButton.Enabled = false;
            // switch the view type
            gridView.View = View.Details;
        }

        private void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manager.OpenMetaData();

            // Get selected video, display metadata contents
            // TODO: Trigger on double click to avoid too many queries if too slow
            if (gridView.SelectedItems.Count <= 0) return;
            // Get selected item
            var item = gridView.SelectedItems[0];
            // Pass the file along to be displayed
            //var path = (string)item.Tag;
            //var files = Files.GetVideoFiles(path);
            //if (files.Count == 0) return;
            var file = (VideoFile)item.Tag;//files[0];
            Manager.DisplayVideoFileMetadata(file);
        }

        public void SimpleFilter(string searchString)
        {
            // no items
            gridView.Items.Clear();

            fullList.ForEach(item =>
            {
                if (item.Name.ToLower().Contains(searchString.ToLower()))
                {
                    gridView.Items.Add(item);
                }
            });
        }

        public void AdvancedFilter(string searchString, CheckedListBox.CheckedItemCollection checkedItems)
        {
            // Start from scratch
            gridView.Items.Clear();

            // Repopulate if empty search
            if (checkedItems.Count == 0 || searchString == "")
            {
                fullList.ForEach(item => gridView.Items.Add(item));
                return;
            }

            // For each video file showing:
            fullList.ForEach(item =>
            {
                // Big Linq Statement Translation:
                //  - Find tag entries from file that match type of checked items
                //  - Any entry that contains the search string, add that file to view
                var file = (VideoFile)item.Tag;
                if (checkedItems.Cast<Tag>().Select(tag => 
                    file.Tags.Find(entry => entry.TypeId == tag.Id)).
                        Any(match => match != null && match.Data.ToLower().Contains(searchString.ToLower())))
                {
                    gridView.Items.Add(item);
                }
            });
        }

        public void EmptyFilter()
        {
            gridView.Items.Clear();
            gridView.Items.AddRange(fullList.ToArray());
        }
    }
}
