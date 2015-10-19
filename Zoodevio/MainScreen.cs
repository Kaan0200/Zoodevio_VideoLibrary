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

        public MainScreen()
        {
            InitializeComponent();
        }

        #region Screen Lifecycle

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
