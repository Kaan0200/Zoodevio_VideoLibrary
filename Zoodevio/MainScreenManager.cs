using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoodevio.Managers;

namespace Zoodevio
{
    class MainScreenManager
    {

        public void SetLibraryRoot(string rootURL)
        {
            DirectoryInfo root = new DirectoryInfo(rootURL);
            DirectoryInfo subRoot = root;
            DirectoryInfo[] subDirs = root.GetDirectories("*.*", System.IO.SearchOption.AllDirectories);
            
            while (subDirs.Length > 0)
            {

            }
            root.GetFiles();
        }

        public void SetManagers(FileManager fileManager, LibraryManager libraryManager, MetadataManager metadataManager, SearchManager searchManager)
        {
            throw new NotImplementedException();
        }
    }
}
