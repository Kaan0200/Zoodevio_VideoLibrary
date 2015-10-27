/*
 * Manages the table of files stored on the system.
 * Enables adding, removing, or modifying file entries and their attributes.
 */

using System;
using System.Collections.Generic;
using System.Data;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Files 
    {
        private static string _table = "files";
        
        // add a file to the database, or ovewrites an existing file 
        // returns a response code
        public static Response AddFile(VideoFile file, Boolean overwrite)
        {
            // locate the video file if it exists
            VideoFile databaseFile = GetFile(file.Id);
            string[] rows = 
            {
                "path",
                "date_added",
                "date_edited"
            };
            string[] data =
            {
                file.Path,
                (file.DateAdded != null) ? file.DateAdded.ToString() : DateTime.Now.ToString(),
                DateTime.Now.ToString(),
            };
            if (databaseFile == null)
            {
                // insert a new file if none exists
                Boolean success = Database.SimpleInsertQuery(_table, rows, data);

                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else if (overwrite)
            {
                // overwrite the old file if overwrite true
                Boolean success = Database.SimpleUpdateQuery(_table, "id", file.Id, rows, data); 
                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else
            {
                return Response.FailedOverwrite;
            }
        }

        // add multiple files to the database
        // returns an array of response codes - one per file
        public static Response[] AddFiles(List<VideoFile> files, Boolean overwrite)
        {
            Response[] Response = new Response[files.Count];
            for(int i = 0; i < files.Count; i++)
            {
                Response[i] = AddFile(files[i], overwrite);
            }
            return Response; 
        }

        // get all file object(s) in the database that have a certain path
        // WARNING: adds a null entry if data doesn't exist
        // probably need to improve that behavior
        public static List<VideoFile> GetVideoFiles(String path)
        {
            List<IDataRecord> data = Database.ReadLikeQuery(_table, "path", path, Database.LikeLocation.Both);
            List<VideoFile> files = new List<VideoFile>();
            foreach (IDataRecord record in data)
            {
                files.Add(VideoFileFromRecord(record));
            }
            return files;
        }

        // get a file object by ID from the database
        public static VideoFile GetFile(int id)
        {
            // get matching file from database
            // may be worthwhile to add error handling on this - constraint: data should always be length 1
            List<IDataRecord> data = Database.SimpleReadQuery(_table, "id", id.ToString());
            return VideoFileFromRecord(data[0]); 
        }

        // generate a video file from a row of raw data
        // or null if no data exists
        private static VideoFile VideoFileFromRecord(IDataRecord row)
        {
            if (row == null)
            {
                return null;
            }
            int id = row.GetInt32(0); 
            return new VideoFile(
                id,
                row.GetString(1),
                Tags.GetFileTags(id),
                Convert.ToDateTime(row.GetDateTime(2)),
                Convert.ToDateTime(row.GetDateTime(3)));
        }

        // delete a file from the database by ID 
        public static Boolean DeleteFile(VideoFile file)
        {
            // no need to check if it exists; nothing will happen if not
            return Database.SimpleDeleteQuery(_table, "id", file.Id); 
        }

    }
}
