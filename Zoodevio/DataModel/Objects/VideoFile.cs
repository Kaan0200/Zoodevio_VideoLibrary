/* 
 * A file entry and its properties. 
 */

using System;

namespace Zoodevio.DataModel.Objects
{
    public class VideoFile
    {
        // the file's ID -- never changed, set by the database
        // does not exist in new File objects not yet in the database
        public int Id { get; }

        // the full on-system path to the file
        public string Path;

        // the date the file was added to the database
        public DateTime DateAdded { get; }

        // the date the file was last edited and saved (in Zoodevio)
        public DateTime DateEdited;

        // the tags associated with this file
        public Tag[] Tags;

        // constructor for a new file entity
        public VideoFile(string path, Tag[] tags)
        {
            Path = path;
            Tags = tags;
        }

    }
}