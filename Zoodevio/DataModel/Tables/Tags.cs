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
        
    }
}