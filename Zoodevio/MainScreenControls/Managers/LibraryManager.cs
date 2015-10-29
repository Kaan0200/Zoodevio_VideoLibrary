using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.Managers
{
    public class LibraryManager
    {
        private MainScreenManager _parentManager;
        private LibraryPanelControl _control;

        public LibraryManager(MainScreenManager _manager, LibraryPanelControl libraryPanelControl)
        {
            _parentManager = _manager;
            _control = libraryPanelControl;
        }

        public void RefreshLibraryFromDatabase()
        {
          var folders  = Folders.GetAllFolders();
          _control.AddFoldersToView(folders);
        }

        public void SelectFolderInTreeView(ZoodevioNode node)
        {
            _parentManager.FileManager.DisplaySelectedFolder(node);
        }
    }
}