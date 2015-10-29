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
    public partial class ListViewControl : UserControl
    {
        public FileManager Manager;

        public ListViewControl()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        public void DisplayFolderInView(List<VideoFile> files)
        {   // Add files from data source
            dataGridView1.DataSource = files;
        }
    }
}
