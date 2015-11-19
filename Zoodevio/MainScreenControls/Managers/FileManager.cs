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

        public FileManager(MainScreenManager manager, GridViewControl gridViewControl)
        {
            _parentManager = manager;
            _gridControl = gridViewControl;
        }

        public void DisplaySelectedFolderContents(TreeNode selection)
        {
            List<VideoFile> files = Folders.GetVideoFilesInFolder(Convert.ToInt32(selection.Tag));
            if (files.Count != 0)
            {
                // if grid control, as in create icons for files
                if (_gridControl.Visible == true)
                {
                    _gridControl.ClearView();
                    files.ForEach(f => _gridControl.CreateVideoIcon(f));

                } else { // list control, populate data set
                
                }
            }
        }
    }
}