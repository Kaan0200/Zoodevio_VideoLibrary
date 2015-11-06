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
        private ListViewControl _listControl;

        public FileManager(MainScreenManager manager, GridViewControl gridViewControl, ListViewControl listViewControl)
        {
            _parentManager = manager;
            _gridControl = gridViewControl;
            _listControl = listViewControl;
        }

        public void DisplaySelectedFolderContents(TreeNode selection)
        {
            // get the id of the folder from the tag value on the node
            List<VideoFile> videoFiles = Folders.GetVideoFilesInFolder(Convert.ToInt32(selection.Tag));
            if (videoFiles.Count > 0)
            {
                _listControl.DisplayFolderInView(videoFiles);
            }
        }
    }
}