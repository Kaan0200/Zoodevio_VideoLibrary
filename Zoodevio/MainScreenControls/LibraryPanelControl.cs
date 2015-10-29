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

        public void AddFoldersToView(List<Folder> folders )
        {
            // Make a node for every folder with its ID as a key
            //var nodes = folders.ToDictionary(f => f.Id, 
              //  f => new ZoodevioNode(f.Name, f.Id));
            /*
            var nodes = new ZoodevioNode[folders.Count*2];
            foreach (var folder in folders)
            {
                nodes[folder.Id] = new ZoodevioNode(folder.Name, folder.Id);
            }
            
            ZoodevioNode root = null;
            foreach (var folder in folders)
            {   
                // Save the root or add this folder to its parent's kids
                ZoodevioNode node = nodes[folder.Id];
                if (folder.ParentId == -1)
                {
                    root = node;
                }
                else if (nodes[folder.ParentId] != null)
                {
                    nodes[folder.ParentId].Nodes.Add(node);
                }
                else
                {
                    folderTreeview.Nodes.Add(node);
                }
            }

            // If we found a root (basically always true)
            if (root != null)
            {   // Add it and all of its children with it
                folderTreeview.Nodes.Add(root);
            }
            else
            {   // Otherwise show an error message.
                MessageBox.Show("Library refresh operation failed.",
                    "Zoodevio Video Library",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            */
            // Add all nodes with no hierarchy
            foreach (var folder in folders)
            {
                folderTreeview.Nodes.Add(new ZoodevioNode(folder.Name, folder.Id));
            }
        }

        private void folderTreeview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the selected node
            var node = (ZoodevioNode)folderTreeview.SelectedNode;

            // Send it to the list view
            Manager.SelectFolderInTreeView(node);
        }
    }

    public class ZoodevioNode : TreeNode
    {
        public int Id { get; }

        public ZoodevioNode(String text, int id) : base(text)
        {
            this.Id = id;
        }
    }
}
