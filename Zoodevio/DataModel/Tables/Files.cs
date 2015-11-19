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
        private static string _fileTagsTable = "tag_contents";
        
        // add a file to the database, or ovewrites an existing file 
        // returns a response
        public static Response AddFile(VideoFile file, int parentId, bool overwrite)
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
                if (success == false)
                {
                    return Response.FailedDatabase;
                }
                else
                {
                    // get the new file's ID
                    int id = Database.GetLastInsertID(_table);
                    Response tagSuccess = AssociateFileTags(file.Tags, id); 
                    return (tagSuccess.Equals(Response.Success)) ? Response.Success : Response.FailedDatabase;

                }
            }
            else if (overwrite)
            {
                // overwrite the old file if overwrite true
                bool success = Database.SimpleUpdateQuery(_table, "id", file.Id, rows, data);
                if (success == false)
                {
                    return Response.FailedDatabase;
                }
                else
                {
                    // get the new file's ID
                    int id = Database.GetLastInsertID(_table);
                    Response tagSuccess = AssociateFileTags(file.Tags, id);
                    return (tagSuccess.Equals(Response.Success)) ? Response.Success : Response.FailedDatabase;

                }
            }
            else
            {
                return Response.FailedOverwrite;
            }
        }

        // add multiple files to the database
        // returns an array of response codes - one per file
        public static Response[] AddFiles(List<VideoFile> files, int[] parentIds, bool overwrite)
        {
            Response[] Response = new Response[files.Count];
            for(int i = 0; i < files.Count; i++)
            {
                Response[i] = AddFile(files[i], parentIds[i], overwrite);
            }
            return Response; 
        }

        // associate a file_location relationship with the id of the file's parent folder
        public static Response AssociateFileLocation(VideoFile file, int parentId)
        {
            // locate the video file if it exists
            string[] rows =
            {
                "file_id",
                "folder_id"
            };
            string[] data =
            {
                file.Id.ToString(),
                parentId.ToString()
            };

            // insert a new file location
            bool success = Database.SimpleInsertQuery(_fileLocationsTable, rows, data);
            
            return (success) ? Response.Success : Response.FailedDatabase;
        }

        // associate a list of tags with a given file 
        public static Response AssociateFileTags(List<TagEntry> tags, int fileId)
        {
            foreach (TagEntry tag in tags)
            {
                Response response = AssociateFileTag(tag, fileId);
                if (!response.Equals(Response.Success))
                {
                    return Response.FailedDatabase;
                }
            }
            return Response.Success;
        }

        // associate a tag with a file 
        public static Response AssociateFileTag(TagEntry tag, int fileId)
        {
            string[] rows =
            {
                "type_id",
                "file_id",
                "data"
            };
            string[] data =
            {
                tag.TypeId.ToString(),
                fileId.ToString(),
                tag.Data.ToString()
            };
            bool success = Database.SimpleInsertQuery(_fileTagsTable, rows, data);
            return (success) ? Response.Success : Response.FailedDatabase;
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
            return Database.TruncateTable(_table, true)
                && Database.TruncateTable(_fileLocationsTable, true)
                && Database.TruncateTable(_fileTagsTable, true);
        }
        
        // converts a given DataTable object to a list of video files 
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
