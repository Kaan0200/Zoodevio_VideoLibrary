namespace Zoodevio.Managers
{
    /* This manager is for the basic search controller and for the advanced search controller,
    this will not need to be modified for the first release. */

    public class SearchManager
    {
        private MainScreenManager _parentManager;
        private BasicSearchControl _control;

        public SearchManager(MainScreenManager _manager, BasicSearchControl basicSearchControl)
        {
            _parentManager = _manager;
            _control = basicSearchControl;
        }

        public void SimpleSearch(string searchString)
        {
            _parentManager.FileManager.SimpleFilter(searchString);
        }

        public void EmptySearch()
        {
            _parentManager.FileManager.EmptyFilter();
        }

        public void ResetFilterBox()
        {
            _control.ResetFilterBox();
        }
    }
}