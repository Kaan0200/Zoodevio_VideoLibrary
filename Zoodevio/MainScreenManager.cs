using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;
using Zoodevio.Managers;

namespace Zoodevio
{
    public class MainScreenManager
    {
        private int folderCount = 0;

        // Sets the directory at the given URL as the Zoodevio library root
        public void SetLibraryRoot(string rootURL)
        {
            // If this directory exists, begin mapping file locations
            DirectoryInfo rootDir = new DirectoryInfo(rootURL);
            if (rootDir.Exists) {
                // Clear old root and set new root
                Folder root = SetRootReference(rootDir);
                
                if (root != null)
                {   // Traverse this directory mapping all file/folder locations
                    PeruseDirectory(rootDir, root);
                }
                else
                {
                    // Failed to set new library root, handle error
                }
            }
        }

        // Recursively traverses a file structure mapping video file and folder locations
        private void PeruseDirectory(DirectoryInfo dir, Folder folder)
        {
            // Get all immediately contained subdirectories
            DirectoryInfo[] subDirs = GetImmediateSubDirectories(dir);

            // For each subdirectory:
            for (int i = 0; i < subDirs.Length; i++)
            {
                // Map its location in the database
                Folder subFolder = MapDirectoryAndContents(subDirs[i], folder.Id);

                // Continue the library traversal within
                PeruseDirectory(subDirs[i], subFolder);
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
                Console.WriteLine(e.StackTrace);
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
        private Folder SetRootReference(DirectoryInfo root)
        {
            // TODO: Tell the database to remove its reference to any existing library root
            return MapDirectoryAndContents(root, -1);
        }

        // Adds a directory in the library structure as a "Folder" object in the database
        private Folder MapDirectoryAndContents(DirectoryInfo dir, int parentID)
        {
            // Get folder ID
            int folderID = folderCount++;

            // Find all video files in this folder
            List<VideoFile> files = MapContainedVideoFiles(dir, folderID);
            Folder folder = new Folder(folderID, parentID, dir.Name, files);
            Folders.AddFolder(folder, true);
            return folder;
        }

        // This returns a list of DB VideoFile objects representing all video files in a directory
        private List<VideoFile> MapContainedVideoFiles(DirectoryInfo subDir, int folderID)
        {
            // Prepare file list
            List<VideoFile> files = new List<VideoFile>();

            // Get all supported file extensions
            string[] extensions = GetSupportedFileExtensions();

            // For each supported extension:
            for (int i = 0; i < extensions.Length; i++)
            {
                // Get all contained video files of the same type
                FileInfo[] videoFiles = subDir.GetFiles("*." + extensions[i]);

                // For each video file with the current extension:
                for (int j = 0; j < videoFiles.Length; j++)
                {   // Create the DB object and add it to the list
                    files.Add(new VideoFile(videoFiles[j].FullName, new List<TagEntry>()));
                }
            }
            Files.AddFiles(files, true);
            return files;
        }

        public void SetManagers(FileManager fileManager, LibraryManager libraryManager, MetadataManager metadataManager, SearchManager searchManager)
        {
            //throw new NotImplementedException();
        }
    }
}
