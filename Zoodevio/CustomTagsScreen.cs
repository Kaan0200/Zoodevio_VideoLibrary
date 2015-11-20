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
    public partial class CustomTagsScreen : Form
    {
        public CustomTagsScreen()
        {
            InitializeComponent();
        }


        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
