using System;
using System.Collections.Generic;
using System.IO;
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
    public class MainScreenManager
    {
        public MainScreen Control;


        public FileManager FileManager;
        public LibraryManager LibraryManager;
        public MetadataManager MetadataManager;
        public SearchManager SearchManager;

        public MainScreenManager(MainScreen control)
        {
            Control = control;
            // control is set, create the other managers
            FileManager = new FileManager(this, Control.GridViewControl, Control.ListViewControl);
            LibraryManager = new LibraryManager(this, Control.LibraryPanelControl);
            MetadataManager = new MetadataManager(this, Control.MetadataViewControl);
            SearchManager = new SearchManager(this, Control.BasicSearchControl);
            // set them to their respective controls
            Control.BasicSearchControl.Manager = SearchManager;
            Control.GridViewControl.Manager = FileManager;
            Control.ListViewControl.Manager = FileManager;
            Control.LibraryPanelControl.Manager = LibraryManager;
            Control.MetadataViewControl.Manager = MetadataManager;
        }

        // Sets the directory at the given URL as the Zoodevio library root
        public void SetLibraryRoot(string rootURL)
        {
            // If this directory exists, begin mapping file locations
            DirectoryInfo rootDir = new DirectoryInfo(rootURL);
            if (rootDir.Exists) {
                // Clear old root and set new root
                Folder rootFolder = SetRootReference(rootDir);
                
                if (rootFolder != null)
                {
                    // Add files in top level root directory
                    MapContainedVideoFiles(rootDir, rootFolder.Id);

                    // Traverse this directory mapping all file/folder locations
                    PeruseDirectory(rootDir, rootFolder);
                }
                else
                {
                    // Failed to set new library root, handle error
                    throw new Exception("Failed to set selected directory as library root.");
                }
            }
        }

        // Recursively traverses a directory mapping video file and folder locations
        private void PeruseDirectory(DirectoryInfo dir, Folder folder)
        {
            // Get all immediately contained subdirectories
            DirectoryInfo[] children = GetImmediateSubDirectories(dir);

            // For each subdirectory:
            for (int i = 0; i < children.Length; i++)
            {
                // Map its location and contents in the database
                Folder childFolder = MapDirectoryAndContents(children[i], folder.Id);

                if (childFolder != null)
                {
                    // Continue the library traversal within
                    PeruseDirectory(children[i], childFolder);
                }
            }
        }

        // Adds a directory in the library structure as a folder object in the database
        private Folder MapDirectoryAndContents(DirectoryInfo dir, int parentID)
        {
            // Try to add this directory as a folder in the database
            Folder folder = new Folder(parentID, dir.Name);
            Response response = Folders.AddFolder(folder, true);

            // If the folder was added successfully:
            if (response == Response.Success)
            {
                // Add all the contained video files to the database
                MapContainedVideoFiles(dir, folder.Id);

                // Return the successfully added folder
                return folder;
            }

            // Otherwise stop digging in this directory
            return null;
        }

        // This adds all video files in a directory to the database
        private void MapContainedVideoFiles(DirectoryInfo dir, int parentID)
        {
            // Get all supported file extensions
            string[] extensions = GetSupportedFileExtensions();

            // For each supported extension:
            for (int i = 0; i < extensions.Length; i++)
            {
                // Get all contained video files of the same type
                FileInfo[] videoFiles = dir.GetFiles("*." + extensions[i]);

                // For each video file with the current extension:
                for (int j = 0; j < videoFiles.Length; j++)
                {
                    // Create a database VideoFile object for the file
                    VideoFile file = new VideoFile(videoFiles[j].FullName, GetDefaultTags());

                    // Try to add the file to the database
                    Response response = Files.AddFile(file, true);

                    // Report if file addition was unsuccessful
                    if (response != Response.Success)
                    {
                        Console.WriteLine("Files table addition failed:\n    " + videoFiles[j].FullName);
                    }
                }
            }
        }

        // Set new library root reference to the given directory
        private Folder SetRootReference(DirectoryInfo root)
        {
            // Make a folder object to use as the new root
            Folder rootFolder = new Folder(-1, root.FullName);
                
            // Replace the current folder structure with the childless new root
            Response response = Folders.DeleteAllFolders(rootFolder);
            Console.Write(response);
            // If setting the new root was successful:
            if (response == Response.Success)
            {
                // Wipe all existing files
                Files.DeleteAllFiles();

                // Begin building the tree from the root folder
                return rootFolder;
            }

            // If this was unsuccessful, the process stops here.
            return null;
        }

        // Get the top level subdirectories in a diven directory if possible
        private DirectoryInfo[] GetImmediateSubDirectories(DirectoryInfo dir)
        {
            try
            { 
                // Try to get all top level sub directories in this folder
                return dir.GetDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception e)
            {   
                // Something went wrong with permissions or nonexistent references
                Console.WriteLine("Error getting subdirectories, not sure how to handle yet");
                Console.WriteLine(e.StackTrace);
                return new DirectoryInfo[0];
            }
        }

        // Gets an array of strings containing all supported file extensions
        private string[] GetSupportedFileExtensions()
        {
            // TODO: Get an array of supported file extensions in "xxx" format (no '.')
            return new string[] { "mp4", "avi", "mov", "flv" };
        }

        // This gets a list of default required tags a video file has
        private List<TagEntry> GetDefaultTags()
        {
            // TODO: Get default tags from DB
            List<TagEntry> defaultTags = new List<TagEntry>();
            return defaultTags;
        }

        public void SetManagers(FileManager fileManager, LibraryManager libraryManager, MetadataManager metadataManager, SearchManager searchManager)
        {
            //throw new NotImplementedException();
        }
    }
}
