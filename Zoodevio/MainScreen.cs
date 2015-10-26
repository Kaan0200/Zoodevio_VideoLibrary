using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class MainScreen : Form
    {
        private bool _gridViewToggle; // true is gridview, false is listview
        private bool _searchViewToggle = true;
        private bool _metadataViewToggle = true;

        private MainScreenManager _mainManager;

        public MainScreen()
        {
            InitializeComponent();
            SetupManagers();
        }

        // Setups the manager for the mainscreen and then gives itself to all children managers
        private void SetupManagers()
        {
            _mainManager = new MainScreenManager();
            var searchManager = new SearchManager(_mainManager);
            var fileManager = new FileManager(_mainManager);
            var metadataManager = new MetadataManager(_mainManager);
            var libraryManager = new LibraryManager(_mainManager);
            _mainManager.SetManagers(fileManager, libraryManager, metadataManager, searchManager);
        }

        #region Screen Lifecycle

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void hideMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // swap the toggle, and then set the value to the control
            Console.WriteLine("Toggled Metadata : " + !_metadataViewToggle);
            _metadataViewToggle = !_metadataViewToggle;
            metadataViewControl1.Visible = _metadataViewToggle;
        }

        private void hideSearchAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Toggled Search Area : " + !_searchViewToggle);
            _searchViewToggle = !_searchViewToggle;
            basicSearchControl1.Visible = _searchViewToggle;
        }

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
    }
}
