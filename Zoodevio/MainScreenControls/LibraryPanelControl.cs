using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        private TreeNode _lastSelectedNode;

        public LibraryPanelControl()
        {
            InitializeComponent();
        }
        
        /* Adds all the folders contained in the list to the heirachy in
        their correct order and structure */
        public void AddFoldersToView(List<Folder> folders)
        {
            // find the parent first,
            Folder parent = folders.Find(f => f.ParentId == Database.ROOT_PARENT);
            folders.Remove(parent); // remove it from the list
            var parentNode = new TreeNode {
                Text = parent.Name,
                Tag = parent.Id
            };
            folderTreeview.Nodes.Add(parentNode);
            // start building the tree
            AddChildrenFoldersToNode(parentNode, ref folders); 
        }

        private void AddChildrenFoldersToNode(TreeNode parent, ref List<Folder> folders)
        {
            // find all the children with this parent
            var children = folders.FindAll(f => f.ParentId == Convert.ToInt32(parent.Tag));
            // remove all the children from the list of folders
            folders.RemoveAll(f => children.Contains(f));
            // for each child, create a new node and put it in the parent
            children.ForEach(f => parent.Nodes.Add(new TreeNode
            {
                Text = f.Name, Tag = f.Id
            }));
            // for each new node create create the children
            foreach (TreeNode node in parent.Nodes)
            {
                AddChildrenFoldersToNode(node, ref folders);
            }
        }

        private void folderTreeview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the selected node
            var node = folderTreeview.SelectedNode;

            // Send it to the list view
            Manager.ChangedSelectedFolderNode(node);
        }

        private void folderTreeviewNode_Select(object sender, TreeNodeMouseClickEventArgs e)
        {
            // sometimes there are bad selects, resulting in null node selection
            if (folderTreeview.SelectedNode != null)
            {
                // only fire off method call if the selected node changed
                if (_lastSelectedNode != folderTreeview.SelectedNode)
                {
                    // update
                    _lastSelectedNode = folderTreeview.SelectedNode;
                    // clean call
                    Manager.ChangedSelectedFolderNode(folderTreeview.SelectedNode);
                }
            }
        }

        // this method clears off the values in the treeview
        public void Clear()
        {
            folderTreeview.Nodes.Clear();
        }
    }
}
