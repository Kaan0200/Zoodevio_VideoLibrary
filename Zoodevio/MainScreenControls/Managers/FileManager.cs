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
    }
}