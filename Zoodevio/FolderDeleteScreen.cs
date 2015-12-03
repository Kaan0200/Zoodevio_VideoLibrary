using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio
{
    public partial class FolderDeleteScreen : Form
    {
        // the source so it can be accessed when adding a new Tag
        private BindingSource _source;

        public FolderDeleteScreen()
        {
            InitializeComponent();
        }

        // get a list of all the folders in the system for selection
        private void FolderDeleteScreen_Load(object sender, EventArgs e)
        {
            List<Folder> folders = Folders.GetAllFolders(); 
            _source = new BindingSource();
            _source.DataSource = folders; 
            this.folderListBox.DataSource = _source;
            ((ListBox)this.folderListBox).DisplayMember = "Name";
            ((ListBox)this.folderListBox).ValueMember = "Id";
        }

        private void deleteSelectedButton_Click(Object sender, EventArgs e)
        {
           // confirm deletion
            DialogResult confirm =
                MessageBox.Show(
                    "Warning: Deleting these folders will permanently delete any files within them! Are you sure you want to proceed?",
                    "Confirm Folder Deletion",
                    MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // get root directory 
                string rootDir = Folders.GetFolder(Folders.ROOT_ID).Name; 
                // delete each checked folder and all its files 
                foreach (Folder itemChecked in folderListBox.CheckedItems)
                {
                    Console.WriteLine("Deleting folder " + rootDir + "\\" + itemChecked.Name);
                    List<VideoFile> files = itemChecked.Files;
                    foreach (VideoFile file in files)
                    {
                        Console.WriteLine("Deleting file " + file.Path);
                        Files.DeleteFile(file);
                        File.Delete(file.Path); 
                    }
                    Directory.Delete(rootDir + "\\" + itemChecked.Name);
                    Folders.DeleteFolder(itemChecked);
                }
                this.Dispose();
            }
        }

        private void cancelButton_Click(Object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
