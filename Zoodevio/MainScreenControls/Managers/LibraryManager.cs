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
    }
}