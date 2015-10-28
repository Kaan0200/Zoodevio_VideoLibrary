/* 
 * Manages tags for video files in the database.
 * Includes creating, modifying, and deleting tags, and getting, adding, and removing tags from files in the DB.
 */
 
using System.Collections.Generic;
using System.Data;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Tags
    {
        // the two tables tag information is stored in
        private static string _tagsTable = "tag_contents";
        private static string _typesTable = "tag_types";

        // chunks of data to get when reading 
        private const int CHUNK_SIZE = 2*1024; 

        // get tags associated with a given file id 
        public static List<TagEntry> GetFileTags(int id)
        {
            List<IDataRecord> data = Database.SimpleReadQuery(_tagsTable, "file_id", id.ToString());
            List<TagEntry> tags = new List<TagEntry>(); 
            foreach (IDataRecord row in data)
            {
                tags.Add(new TagEntry( 
                    row.GetInt32(0),
                    row.GetInt32(1), 
                    row.GetInt32(2), 
                    Database.GetBytes(row, 3)
                    ));
            }
            return tags;
        }

        // get all tags of a certain type 
        public static List<TagEntry> GetTagsOfType(int typeId)
        {
            List<IDataRecord> data = Database.SimpleReadQuery(_tagsTable, "type_id", typeId.ToString());
            List<TagEntry> tags = new List<TagEntry>();
            foreach (IDataRecord row in data)
            {
                tags.Add(new TagEntry(
                row.GetInt32(0),
                row.GetInt32(1),
                row.GetInt32(2),
                Database.GetBytes(row, 3)
                ));
            }
            return tags;
        } 

        // Note: TagEntry modifiers don't modify the database directly. They return a VideoFile which can then be written.
        // add or modify a tag on a file object
        // returns the file object with the tag added
        public static VideoFile AddTag(int fileId, TagEntry tag)
        {
            // get the file from the database 
            VideoFile file = Files.GetFile(fileId);
            DoAddTag(file, tag);
            return file;
        }

        // add or modify a group of tags on a file
        public static VideoFile AddTags(int fileId, List<TagEntry> tags)
        {
            VideoFile file = Files.GetFile(fileId);
            foreach (TagEntry tag in tags)
            {
                DoAddTag(file, tag);
            }
            return file; 
        }

        // helper method for code portability
        private static void DoAddTag(VideoFile file, TagEntry tag)
        {
            // remove an old version if it's there
            if (file.Tags.Contains(tag))
            {
                file.Tags.Remove(tag);
            }
            file.Tags.Add(tag);
        }

        // add the same tag to a batch of files 
        public static List<VideoFile> BatchAddTag(List<VideoFile> files, TagEntry tag)
        {
            for (int i = 0; i < files.Count; i++)
            {
                // PLEASE TEST: not sure if works this way in C#
                DoAddTag(files[i],tag);
            }
            return files; 
        }

        // remove a tag from a file by type ID
        public static VideoFile RemoveTag(int fileId, int typeId)
        {
            VideoFile file = Files.GetFile(fileId);
            for (int i = 0; i < file.Tags.Count; i++)
            {
                if (file.Tags[i].TypeId == typeId)
                {
                    file.Tags.RemoveAt(i); 
                }
            }
            return file; 
        }

        // add or modify a tag type within the database 
        public static Response AddCustomTag(Tag tag)
        {
            return Response.FailedDatabase;
        }

        // delete a custom tag type from the database
        public static Response DeleteCustomTag(int id)
        {
            return Response.FailedDatabase; 
        }
        


        
    }
}