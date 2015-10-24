using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mainManager = new MainScreenManager();
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
            // Get desired root file location
            string rootURL = "$HOME/MyLibarry";

            // Pass to main screen manager
            _mainManager.SetLibraryRoot(rootURL);
        }
    }
}
