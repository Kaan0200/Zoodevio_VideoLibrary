using System;
using System.Windows.Forms;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class MainScreen : Form
    {
        private bool _gridViewToggle; // true is gridview, false is listview
        private bool _searchViewToggle = true;
        private bool _metadataViewToggle = true;
        private bool _isGridViewNotListView = false;

        private MainScreenManager _mainManager;

        public MainScreen()
        {
            InitializeComponent();
            SetupManagers();

            gridViewControl.Visible = _isGridViewNotListView;
            gridViewControl.Visible = !_isGridViewNotListView;
        }

        // Setups the manager for the MainScreenManager
        private void SetupManagers()
        {
            _mainManager = new MainScreenManager(this);
        }

        #region Screen Lifecycle

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Context Menu

        #region View

        private void hideMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // swap the toggle, and then set the value to the control
            Console.WriteLine("Toggled Metadata : " + !_metadataViewToggle);
            _metadataViewToggle = !_metadataViewToggle;
            metadataViewControl.Visible = _metadataViewToggle;
        }

        private void hideSearchAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Toggled Search Area : " + !_searchViewToggle);
            _searchViewToggle = !_searchViewToggle;
            basicSearchControl.Visible = _searchViewToggle;
        }

        private void toggleListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Toggled between List and Grid view :");
            _isGridViewNotListView = !_isGridViewNotListView;
            gridViewControl.Visible = _isGridViewNotListView;
            listViewControl.Visible = !_isGridViewNotListView;
        }

        #endregion

        #region Settings

        private void setLibraryRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /** SET NEW LIBRARY ROOT **/

            // Start a folder browser dialog window to select root
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            // If the folder browser dialog was a success:
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Get the selected path for the root
                string rootURL = fbd.SelectedPath;

                // Pass to main screen manager to interact with DB
                _mainManager.SetLibraryRoot(rootURL);
            }
        }

        #endregion

        #endregion
    }
}
