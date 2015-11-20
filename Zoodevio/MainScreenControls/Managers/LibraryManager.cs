using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.Managers
{
    public class LibraryManager
    {
        private MainScreenManager _parentManager;
        private LibraryPanelControl _control;

        // a holder for the selected TreeNode so we can observe changes on this variable
        private TreeNode _selectedNode;

        public LibraryManager(MainScreenManager _manager, LibraryPanelControl libraryPanelControl)
        {
            _parentManager = _manager;
            _control = libraryPanelControl;
        }

        public void RefreshLibraryFromDatabase()
        {
            _control.Clear();
            var folders  = Folders.GetAllFolders();
            _control.AddFoldersToView(folders);
        }

        public void ChangedSelectedFolderNode(TreeNode selectedNode)
        {
            // this is a clean select, it will only happen on real changes.
            _parentManager.FileManager.DisplaySelectedFolderContents(selectedNode);
            _parentManager.SearchManager.ResetFilterBox();
        }
    }
}