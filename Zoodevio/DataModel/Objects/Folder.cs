/* 
 * A folder in the hierarchy and its properties. 
 */

using System;

namespace Zoodevio.DataModel.Objects
{
    public class Folder
    {
        // the folder's ID -- never changed, set by the database
        // does not exist in new Folder objects not yet in the database
        public int Id { get; }

        // the folder's parent object
        public Folder Parent;
        public string Name;
        public VideoFile[] Files;

        // constructor for a new, empty folder
        public Folder(Folder parent, string name)
        {
            Parent = parent;
            Name = name;
        }

        // constructor for a folder with ID and files 
        public Folder(int id, Folder parent, string name, VideoFile[] files)
            : this(parent, name)
        {
            Id = id;
            Files = files; 
        }

    }
}