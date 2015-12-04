using System.Windows.Forms;

namespace Zoodevio.Managers
{
    /* This manager is for the basic search controller and for the advanced search controller,
    this will not need to be modified for the first release. */

    public class SearchManager
    {
        private MainScreenManager _parentManager;
        private BasicSearchControl _basicControl;
        private AdvancedSearchScreen _advancedControl;

        public SearchManager(MainScreenManager _manager, BasicSearchControl basicSearchControl)
        {
            _parentManager = _manager;
            _basicControl = basicSearchControl;
        }

        public void SetAdvancedSearchControl(AdvancedSearchScreen screen)
        {
            _advancedControl = screen;
        }

        public void SimpleSearch(string searchString)
        {
            _parentManager.FileManager.SimpleFilter(searchString);
        }

        public void AdvancedSearch(string searchString, CheckedListBox.CheckedItemCollection checkedItems)
        {
            _parentManager.FileManager.AdvancedFilter(searchString, checkedItems);
        }

        public void EmptySearch()
        {
            _parentManager.FileManager.EmptyFilter();
        }

        public void ResetFilterBox()
        {
            _basicControl.ResetFilterBox();
        }
    }
}