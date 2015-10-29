/*
 * Manages the table of files stored on the system.
 * Enables adding, removing, or modifying file entries and their attributes.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Files 
    {
        private static string _table = "files";
        private static string _fileLocationsTable = "file_locations";
        
        // add a file to the database, or ovewrites an existing file 
        // returns a response code
        public static Response AddFile(VideoFile file, bool overwrite)
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
                bool success = Database.SimpleInsertQuery(_table, rows, data);
                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else if (overwrite)
            {
                // overwrite the old file if overwrite true
                bool success = Database.SimpleUpdateQuery(_table, "id", file.Id, rows, data); 
                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else
            {
                return Response.FailedOverwrite;
            }
        }

        // add multiple files to the database
        // returns an array of response codes - one per file
        public static Response[] AddFiles(List<VideoFile> files, bool overwrite)
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
        public static DataTable GetVideoFiles(String path)
        {
            //TODO: Protect empty DT returns
            return Database.ReadLikeQuery(_table, "path", path, Database.LikeLocation.Both);
        }

        // get a file object by ID from the database
        public static VideoFile GetFile(int id)
        {
            //TODO: Protect empty DT returns
            var dt = Database.SimpleReadQuery(_table, "id", id.ToString());
            return new VideoFile(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), null, Convert.ToDateTime(dt.Rows[0][2]), Convert.ToDateTime(dt.Rows[0][3]));
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
                null, // Tags.GetFileTags(id),
                Convert.ToDateTime(row.GetDateTime(2)),
                Convert.ToDateTime(row.GetDateTime(3)));
        }

        // delete a file from the database by ID 
        public static bool DeleteFile(VideoFile file)
        {
            // no need to check if it exists; nothing will happen if not
            return Database.SimpleDeleteQuery(_table, "id", file.Id); 
        }

        // clear the database of all files 
        // WARNING: silently kills the files DB! BEWARE! 
        // also kills their relative locations 
        // should probably only be called along with DeleteAllFolders() 
        public static bool DeleteAllFiles()
        {
            return Database.TruncateTable(_table, true) && Database.TruncateTable(_fileLocationsTable, true);
        }
    }
}
