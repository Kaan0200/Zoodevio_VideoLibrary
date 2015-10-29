using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class LibraryPanelControl : UserControl
    {
        public LibraryManager Manager;

        public LibraryPanelControl()
        {
            InitializeComponent();
        }

        public void AddFolders(List<Folder> folders )
        {
            var nodes = folders.ToDictionary(f => f.Id, f => new TreeNode(f.Name));
            foreach (var folder in folders)
            {
                nodes[folder.ParentId].Nodes.Add(nodes[folder.Id]);
            }
            foreach (var node in nodes)
            {
                folderTreeview.Nodes.Add(node.Value);
            }
        }
    }
}
