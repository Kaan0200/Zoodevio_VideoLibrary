/* 
 * A file entry and its properties. 
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Zoodevio.DataModel.Objects
{
    public class VideoFile
    {
        // the file's ID -- never changed, set by the database
        // does not exist in new File objects not yet in the database
        public int Id { get; }

        // the full on-system path to the file
        public string Path { get; }

        // the date the file was added to the database
        public DateTime DateAdded { get; }

        // the date the file was last edited and saved (in Zoodevio)
        public DateTime DateEdited { get; }

        // the tags associated with this file
        public List<TagEntry> Tags;

        // constructor for a new file entity
        public VideoFile(string path, List<TagEntry> tags)
        {
            Path = path;
            Tags = tags;
        }

        // constructor for file entity with data
        public VideoFile(int id, string path, List<TagEntry> tags, DateTime dateAdded, DateTime dateEdited) : this(path, tags)
        {
            Id = id;
            DateAdded = dateAdded;
            DateEdited = dateEdited; 
        }
    }
}