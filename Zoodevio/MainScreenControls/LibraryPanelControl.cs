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

        public LibraryPanelControl()
        {
            InitializeComponent();
        }
        
        /* Adds all the folders contained in the list to the heirachy in
        their correct order and structure */
        public void AddFoldersToView(List<Folder> folders)
        {
            // set the parent
            Folder parent = folders.Find(f => f.ParentId == -1);
            folders.Remove(parent);
            var parentNode = new ZoodevioNode(parent.Name, parent.Id, parent);
            folderTreeview.Nodes.Add(parentNode);

            AddChildrenFoldersToNode(parentNode, ref folders);
        }

        private void AddChildrenFoldersToNode(ZoodevioNode parent, ref List<Folder> folders)
        {
            var children = folders.FindAll(f => f.ParentId == parent.ZoodevioFolder.Id);
            folders.RemoveAll(f => children.Contains(f));
            children.ForEach(f => parent.Nodes.Add(new ZoodevioNode(f.Name, f.Id, f)));

            foreach (ZoodevioNode zNode in parent.Nodes)
            {
                AddChildrenFoldersToNode(zNode,ref folders);
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
        public Folder ZoodevioFolder { get; }

        public ZoodevioNode(String text, int id, Folder info) : base(text)
        {
            ZoodevioFolder = info;
            this.Id = id;
        }
    }
}
