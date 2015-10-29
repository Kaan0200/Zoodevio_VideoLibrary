using System.Collections.Generic;
using System.ComponentModel;
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
          List<Folder> folders  = Folders.GetAllFolders();
          _control.AddFolders(folders);
        }
    }
}