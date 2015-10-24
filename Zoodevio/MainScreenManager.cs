using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoodevio
{
    class MainScreenManager
    {
        // This class sets the directory at the given URL as the Zoodevio library root
        public void SetLibraryRoot(string rootURL)
        {
            // If this directory exists, begin mapping file locations
            DirectoryInfo root = new DirectoryInfo(rootURL);
            if (root.Exists()) {
                ClearPreviousRoot();
                SearchAndMapDirectory(root);
            }
        }

        // This digs into all of the given directory's subdirectories mapping file and directory locations.
        private void SearchAndMapDirectory(DirectoryInfo subDir)
        {
            MapDirectoryLocation(subDir);
            DirectoryInfo[] subDirs = subDir.GetDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly);

            for (int i = 0; i < subDirs.Length; i++)
            {
                DirectoryInfo subRoot = subDirs[i];
                SearchAndMapDirectory(subRoot);
            }

            string[] extensions = GetSupportedFileExtensions();
            for (int i = 0; i < extensions.Length; i++)
            {

            }
            FileInfo[] videoFiles = subDir.GetFiles("*.mp4");
            for (int i = 0; i < videoFiles.Length; i++)
            {
                MapFileLocation(videoFiles[i], subDir);
            }
        }

        private string[] GetSupportedFileExtensions()
        {
            // TODO: Get an array of supported file extensions in "xxx" format (no '.')
        }

        private void ClearPreviousRoot()
        {
            // TODO: Tell the database to remove its reference to any existing library root
        }

        private void MapDirectoryLocation(DirectoryInfo dir)
        {
            // TODO: Add this directory to the database as a folder object
        }

        private void MapFileLocation(FileInfo videoFile, DirectoryInfo parentDir)
        {
            // TODO: Add this file to the database under the specified parent folder
        }

    }
}
