using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class BasicSearchControl : UserControl
    {
        public SearchManager Manager;

        public BasicSearchControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var entryString = textBox1.Text;
            if (!String.IsNullOrEmpty(entryString))
            {
                Manager.SimpleSearch(textBox1.Text);
            }
            else
            {
                Manager.EmptySearch();
            }
        }

        public void ResetFilterBox()
        {
            textBox1.Text = null;
        }
    }
}
