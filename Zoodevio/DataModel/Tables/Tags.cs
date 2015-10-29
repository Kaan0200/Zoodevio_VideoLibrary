/* 
 * Manages tags for video files in the database.
 * Includes creating, modifying, and deleting tags, and getting, adding, and removing tags from files in the DB.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
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
        public static DataTable GetFileTags(int fileId)
        {
            return Database.SimpleReadQuery(_tagsTable, "file_id", fileId.ToString());
        }

        // update the tags associated with a certain file id 
        public static bool[] UpdateFileTags(int fileId, List<TagEntry> tags)
        {
            DataTable oldTags = GetFileTags(fileId);
            bool[] responses = new bool[tags.Count];
            for(int i = 0; i < tags.Count; i++)
            {
                responses[i] = UpdateFileTag(fileId, tags[i], oldTags); 
            }
            return responses;
        }

        // update a single tag associated with a file 
        public static bool UpdateFileTag(int fileId, TagEntry tag, DataTable oldTags)
        {
            //TODO: uncomment and fix for a datatable
            bool success;
         /*   string[] rows =
                {
                    "type_id",
                    "file_id",
                    "data"
                };
            string[] data =
            {
                  tag.TypeId.ToString(),
                  tag.FileId.ToString(),
                  tag.Data.ToString()
            };
            if (oldTags.Contains(tag))
            {
                TagEntry oldTag = oldTags[(oldTags.IndexOf(tag))];

                success = Database.SimpleUpdateQuery(_tagsTable, "id",
                    oldTag.Id, rows, data);
            }
            else
            {
                success = Database.SimpleInsertQuery(_tagsTable, rows, data); 
            } */
            return false; 
        }

        // get all tags of a certain type 
        public static DataTable GetTagsOfType(int typeId)
        {
            return Database.SimpleReadQuery(_tagsTable, "type_id", typeId.ToString());
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

        // get a tag type entry from the database
        //TODO: rewrite this with proper handling of query return
       /* public static Tag GetTagType(int id)
        {
            var data = ConvertReaderToList(Database.SimpleReadQuery(_typesTable, "id", id.ToString()));

            return TagTypeFromRecord(data[0]);
        }

        private static Tag TagTypeFromRecord(IDataRecord row)
        {
            if (row == null)
            {
                return null;
            }
            return new Tag(
                row.GetInt32(0),
                row.GetString(1),
                row.GetBoolean(2),
                row.GetBoolean(3),
                row.GetBoolean(4),
                row.GetString(5),
                row.GetBoolean(6));
        } 

        // add or modify a tag type within the database 
        public static Response AddCustomTag(Tag type, bool overwrite)
        {
            Tag dbType = GetTagType(type.Id);
            string[] rows =
            {
                "id",
                "name",
                "can_search",
                "can_sort",
                "required",
                "data_type",
            };
            string[] data =
            {
                type.Id.ToString(),
                type.Name,
                type.CanSearch.ToString(),
                type.CanSort.ToString(),
                type.Required ? "1" : "0",
                type.DataType,
            };
            if (type.IsModifiable)
            {
                if (dbType == null)
                {
                    bool success = Database.SimpleInsertQuery(_typesTable, rows, data);
                    return (success) ? Response.Success : Response.FailedDatabase;

                }
                else if (overwrite)
                {
                    // overwrite the old file if overwrite true
                    bool success = Database.SimpleUpdateQuery(_tagsTable, "id", type.Id, rows, data);
                    return (success) ? Response.Success : Response.FailedDatabase;
                }
                else
                {
                    return Response.FailedOverwrite;
                }
            }
            else
            {
                throw new ArgumentException("Unmodifiable tag passed!");
            }
        } 

        // delete a custom tag type from the database
        public static bool DeleteCustomTag(int id)
        {
            // get the tag and make sure it can be modfiied
            Tag type = GetTagType(id);
            if (type.IsModifiable)
            {
                return Database.SimpleDeleteQuery(_tagsTable, "id", type.Id);
            }
            else
            {
                return false; 
            }
        }*/
    }
}