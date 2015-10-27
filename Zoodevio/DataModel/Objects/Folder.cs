/* 
 * A folder in the hierarchy and its properties. 
 */

using System;
using System.Collections.Generic;

namespace Zoodevio.DataModel.Objects
{
    public class Folder
    {
        // the folder's ID -- never changed, set by the database
        // does not exist in new Folder objects not yet in the database
        public int Id { get; }

        // the folder's parent 
        // stored as int id to avoid redundant lookup chains
        public int ParentId;
        public string Name;
        public List<VideoFile> Files;

        #region Constructor

        // constructor for a new, empty folder
        public Folder(int parent, string name)
        {
            ParentId = parent;
            Name = name;
        }

        // constructor for a folder with ID and files 
        public Folder(int id, int parent, string name, List<VideoFile> files)
            : this(parent, name)
        {
            Id = id;
            Files = files; 
        }

        #endregion
    }
}