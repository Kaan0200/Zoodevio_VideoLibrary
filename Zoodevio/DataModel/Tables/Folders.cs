/*
 * Handles accessing, modifying and deleting Folders from the Zoodevio folder hierarchy.
 * Also includes helper functions for building folder trees from a root.
 * This class has a lot of similarities to Files in terms of operations.
 * Might be worth abstracting some of this code.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Folders
    {
        private static string _table = "folders";
        private static string _fileLocationsTable = "file_locations";

        // the id of the root folder
        public const int ROOT_ID = 1; 

        // add a single folder to the database
        public static Response AddFolder(Folder folder, Boolean overwrite)
        {
            // add a folder to the database, or overwrites an existing folder
            // locate the video file if it exists
            Folder databaseFolder = GetFolder(folder.Id);
            Console.Write(databaseFolder);
            string[] rows =
            {
                "name",
                "parent_id"
            };
            string[] data =
            {
                folder.Name,
                folder.ParentId.ToString()
            };
            if (databaseFolder == null)
            {
                // insert a new file if none exists
                Boolean success = Database.SimpleInsertQuery(_table, rows, data);
                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else if (overwrite)
            {
                // overwrite the old file if overwrite true
                Boolean success = Database.SimpleUpdateQuery(_table, "id", folder.Id, rows, data);
                return (success) ? Response.Success : Response.FailedDatabase;
            }
            else
            {
                return Response.FailedOverwrite;
            }
        }

        // add a group of folders to the database
        public static Response[] AddFolders(List<Folder> folders, Boolean overwrite)
        {
            Response[] Response = new Response[folders.Count];
            for (int i = 0; i < folders.Count; i++)
            {
                Response[i] = AddFolder(folders[i], overwrite);
            }
            return Response;
        }

        // get all folders
        public static List<Folder> GetAllFolders()
        {
            // star query the table, get the reader, turn into list of 
            return ConvertDataTableToList(Database.SimpleStarQuery(_table));
        } 

        // get a Folder by ID 
        public static Folder GetFolder(int id)
        {
            // read a simple id query, then convert to folders, and get the first one in the list
            List<Folder> matches = ConvertDataTableToList(Database.SimpleReadQuery(_table, "id", id.ToString()));

            if (matches.Count > 0)
            {
                return matches[0];
            }
            else
            {
                return null;
            }
        }

        // get Folder(s) matching a name string
        // words similarly to GetVideoFiles()
        public static List<Folder> GetFoldersByName(string name)
        {
            return ConvertDataTableToList(Database.ReadLikeQuery(_table, "name", name, Database.LikeLocation.Both));
        }

        // get the folder to which a given file ID belongs
        public static Folder GetContainingFolder(int fileId)
        {
            List<Folder> matches =
                ConvertDataTableToList(Database.SimpleReadQuery(_fileLocationsTable, "file_id", fileId.ToString()));
            if (matches.Count > 0)
            {
                return GetFolder(matches[0].ParentId);
            }
            else
            {
                return null;
            }
        }

        // delete a file from the database by ID
        // returns true if successful, false otherwise
        public static bool DeleteFolder(Folder folder)
        {
            return Database.SimpleDeleteQuery(_table, "id", folder.Id); 
        }

        // generate a folder object from a row of raw data
        // returns null if no data exists
        private static Folder FolderFromRecord(IDataRecord row)
        {
            if (row == null)
            {
                return null;
            }

            var id = row.GetValue(0);
            //int id = row.GetInt32(0);
            return new Folder(
                (int)id,
                row.GetInt32(1),
                row.GetString(2),
                GetVideoFilesInFolder((int)id));
        }

        // get all video files associted with a given folder
        // the opposite of GetContainingFolder()
        public static List<VideoFile> GetVideoFilesInFolder(int folderId)
        {
            // get a list of file ids matching this folder as parent
            var table = Database.SimpleReadQuery(_fileLocationsTable,
                "folder_id", folderId.ToString());

            var intList = new List<int>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                intList.Add(Convert.ToInt32(table.Rows[i][0]));
            }

            // generate videofiles for them
            return intList.Select(id => Files.GetFile(id)).ToList(); 
        } 


        // clear the database of all folders and reset the hierarchy
        // setting a provided folder as root 
        // WARNING: silently kills the folders DB! BEWARE! 
        // does not kill file locations. to do that, call DeleteAllFiles() 
        // should probably only be called along with DeleteAllFiles() for that reason
        public static Response DeleteAllFolders(Folder newRoot)
        {
            Database.TruncateTable(_table, true);
            return AddFolder(newRoot, false); 
        }

        private static List<Folder> ConvertDataTableToList(DataTable table)
        {
            List<Folder> returnList = new List<Folder>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                // Get folder info from row to make folder object
                int id = Convert.ToInt32(row["id"]);
                int parentID = Convert.ToInt32(row["parent_id"]);
                string name = row["name"].ToString();
                List<VideoFile> files = GetVideoFilesInFolder(id);

                // Add folder instance to return list
                returnList.Add(new Folder(id, parentID, name, files));
            }
            return returnList;
        }
    }
}