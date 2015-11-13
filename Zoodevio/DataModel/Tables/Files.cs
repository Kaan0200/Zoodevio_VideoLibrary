/*
 * Manages the table of files stored on the system.
 * Enables adding, removing, or modifying file entries and their attributes.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
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
                (file.DateAdded.Equals(DateTime.MinValue)) ? DateTime.Now.ToString() : file.DateAdded.ToString(),
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
        public static List<VideoFile> GetVideoFiles(String path)
        {
            return ConvertDataTableToList(Database.ReadLikeQuery(_table, "path", path, Database.LikeLocation.Both));
        }

        // get a file object by ID from the database
        public static VideoFile GetFile(int id)
        {
            // get matching file from database
            List<VideoFile> matches = ConvertDataTableToList(Database.SimpleReadQuery(_table, "id", id.ToString()));
            if (matches.Count > 0)
            {
                return matches[0];
            }
            else
            {
                return null;
            }
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
        
        private static List<VideoFile> ConvertDataTableToList(DataTable table)
        {
            List<VideoFile> returnList = new List<VideoFile>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                returnList.Add(new VideoFile(
                    Convert.ToInt32(row["id"]),
                    row["path"].ToString(),
                    null,
                    DateTime.Parse(row["date_added"].ToString()),
                    DateTime.Parse(row["date_edited"].ToString())
                    ));
            }
            return returnList;
        }
    }
}
