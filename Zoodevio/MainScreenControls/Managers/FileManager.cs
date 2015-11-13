﻿using System.Collections.Generic;
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
            Folder folder = Files.GetFilesByFolderName(selection.Name);
            if (folder != null)
            {
                _listControl.DisplayFolderInView(folder.Files);
            }
        }
    }
}