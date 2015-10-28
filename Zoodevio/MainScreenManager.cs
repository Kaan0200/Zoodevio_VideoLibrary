using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            FileManager = new FileManager(this);
            LibraryManager = new LibraryManager(this);
            MetadataManager = new MetadataManager(this);
            SearchManager = new SearchManager(this);
            // set them to their respective controls
        }

        // Sets the directory at the given URL as the Zoodevio library root
        public void SetLibraryRoot(string rootURL)
        {
            // If this directory exists, begin mapping file locations
            DirectoryInfo root = new DirectoryInfo(rootURL);
            if (root.Exists) {
                // Clear old root and set new root
                SetRootReference(root);
                
                // Traverse this directory mapping all file/folder locations
                MapDirectoryContents(root);
            }
        }

        // Recursively traverses a file structure mapping video file and folder locations
        private void MapDirectoryContents(DirectoryInfo subDir)
        {
            // Find all video files in this folder
            MapAllContainedFileLocations(subDir);

            // Get all immediately contained subdirectories
            DirectoryInfo[] subDirs = GetImmediateSubDirectories(subDir);
            
            // For each subdirectory:
            for (int i = 0; i < subDirs.Length; i++)
            {
                // Map its location in the database
                MapDirectoryLocation(subDirs[i]);

                // Continue the library traversal within
                MapDirectoryContents(subDirs[i]);
            }
        }

        // Get the top level subdirectories in a diven directory if possible
        private DirectoryInfo[] GetImmediateSubDirectories(DirectoryInfo dir)
        {
            try
            {  // Try to get all top level sub directories in this folder
                return dir.GetDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
            } catch (Exception e)
            {    // Something went wrong with permissions or nonexistent references
                Console.WriteLine("Error getting subdirectories, not sure how to handle yet");
                return new DirectoryInfo[0];
            }
        }

        // Gets an array of strings containing all supported file extensions
        private string[] GetSupportedFileExtensions()
        {
            // TODO: Get an array of supported file extensions in "xxx" format (no '.')
            return new string[] { "mp4", "avi" };
        }

        // Set new library root reference to the given directory
        private void SetRootReference(DirectoryInfo root)
        {
            // TODO: Tell the database to remove its reference to any existing library root
            // TODO: Set the new root reference to the given directory
        }

        // Adds a directory in the library structure as a "Folder" object in the database
        private void MapDirectoryLocation(DirectoryInfo dir)
        {
            // TODO: Add this directory to the database as a folder object
        }

        // Adds a supported video file to the library as a "File" object in the database
        private void MapFileLocation(FileInfo videoFile, String extension, DirectoryInfo parentDir)
        {
            // TODO: Add this file to the database under the specified parent folder
        }

        // This maps the location of every supported video file in a given directory
        private void MapAllContainedFileLocations(DirectoryInfo subDir)
        {
            // Get all supported file extensions
            string[] extensions = GetSupportedFileExtensions();

            // For each supported extension:
            for (int i = 0; i < extensions.Length; i++)
            {
                // Get all contained video files of the same type
                FileInfo[] videoFiles = subDir.GetFiles("*." + extensions[i]);

                // For each video file with the current extension:
                for (int j = 0; j < videoFiles.Length; j++)
                {   // Map its location in the database
                    MapFileLocation(videoFiles[j], extensions[i], subDir);
                }
            }
        }

        public void SetManagers(FileManager fileManager, LibraryManager libraryManager, MetadataManager metadataManager, SearchManager searchManager)
        {
            //throw new NotImplementedException();
        }
    }
}
