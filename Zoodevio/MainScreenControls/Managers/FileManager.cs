using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.Managers
{
    public class FileManager
    {
        private MainScreenManager _parentManager;
        private GridViewControl _gridControl;

        private TreeNode currentSelection;

        public FileManager(MainScreenManager manager, GridViewControl gridViewControl)
        {
            _parentManager = manager;
            _gridControl = gridViewControl;
        }

        public void DisplaySelectedFolderContents(TreeNode selection)
        {
            if (selection == null) return;
            currentSelection = selection;
            var files = Folders.GetVideoFilesInFolder(Convert.ToInt32(selection.Tag));
            if (files.Count == 0) return;
            // if grid control, as in create icons for files
            if (_gridControl.Visible == true)
            {
                _gridControl.ClearView();
                files.ForEach(f => _gridControl.CreateVideoIcon(f));

            } else { // list control, populate data set
                
            }
        }

        public void RefreshListView()
        {
            _gridControl.ClearView();
            DisplaySelectedFolderContents(currentSelection);
        }

        public void DisplayVideoFileMetadata(VideoFile file)
        {
            _parentManager.MetadataManager.DisplayVideoFileMetadata(file);
        }
    }
}