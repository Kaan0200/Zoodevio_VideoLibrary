/* 
 * A file entry and its properties. 
 */

using System;
using System.IO;

namespace Zoodevio.DataModel.Objects
{
    public class File
    {
        // the file's ID -- never changed, set by the database
        // does not exist in new File objects not yet in the database
        public int Id { get; }

        // the full on-system path to the file
        public string Path { get; set; }

        // the date the file was added to the database
        public DateTime DateAdded { get; }

        // the date the file was last edited and saved (in Zoodevio)
        public DateTime DateEdited { get; set; }

        // the tags associated with this file
        public Tag[] Tags { get; set; }

        // constructor for a new file entity
        public File(string path, Tag[] tags)
        {
            Path = path;
            Tags = tags;
        }

    }
}