using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel.Objects;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class GridViewControl : UserControl
    {
        public FileManager Manager;

        public GridViewControl()
        {
            InitializeComponent();

            // this is the default, set it so we know for certain
            gridView.View = View.LargeIcon;

            // add the columns to the gridView
            var fileNameColumn = new ColumnHeader("File")
            {
                Text = "File",
                Width = 200
            };
            var extensionColumn = new ColumnHeader("Extension")
            {
                Text = "ext",
                Width = 50
            };
            var lengthColumn = new ColumnHeader("Length")
            {
                Text = "Length",
                Width = 100
            };
            gridView.Columns.Add(fileNameColumn);
            gridView.Columns.Add(extensionColumn);
            gridView.Columns.Add(lengthColumn);

            // disable the icon view since we are already there
            iconViewButton.Enabled = false;
        }

        public void ClearView()
        {
            gridView.Items.Clear();
        }

        internal void CreateVideoIcon(VideoFile f)
        {
            string[] paths = f.Path.Split(Convert.ToChar("\\"));
            string name = paths[paths.Length - 1];
            gridView.Items.Add(name);
        }

        private void changeToIcon_Click(object sender, EventArgs e)
        {
            // toggle the button enables
            iconViewButton.Enabled = false;
            listViewButton.Enabled = true;
            // switch the view type
            gridView.View = View.LargeIcon;
        }

        private void changeToList_Click(object sender, EventArgs e)
        {
            // toggle the button enables
            iconViewButton.Enabled = true;
            listViewButton.Enabled = false;
            // switch the view type
            gridView.View = View.Details;
        }
    }
}
