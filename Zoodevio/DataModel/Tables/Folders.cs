/*
 * Handles accessing, modifying and deleting Folders from the Zoodevio folder hierarchy.
 * Also includes helper functions for building folder trees from a root.
 * This class has a lot of similarities to Files in terms of operations.
 * Might be worth abstracting some of this code.
 */

using System;
using System.Collections.Generic;
using System.Data;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Folders
    {
        private static string _table = "folders";
        private static string _fileLocationsTable = "file_locations"; 

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

        // get a Folder by ID 
        public static Folder GetFolder(int id)
        {
            List<IDataRecord> data = Database.SimpleReadQuery(_table, "id", id.ToString());
            if (data.Count == 0)
            {
                return null;
            }
            return FolderFromRecord(data[0]);
        }

        // get Folder(s) matching a name string
        // words similarly to GetVideoFiles()
        public static List<Folder> GetFoldersByName(string name)
        {
            List<IDataRecord> data = Database.ReadLikeQuery(_table, "name", name, Database.LikeLocation.Both);
            List<Folder> folders = new List<Folder>();
            foreach (IDataRecord record in data)
            {
                folders.Add(FolderFromRecord(record));
            }
            return folders;
        }

        // get the folder to which a given file ID belongs
        public static Folder GetContainingFolder(int fileId)
        {
            List<IDataRecord> data = Database.SimpleReadQuery(_fileLocationsTable,
                "file_id", fileId.ToString());
            IDataRecord row = data[0]; // should only be one match anyway
            int folderId = row.GetInt32(1);
            return GetFolder(folderId); 
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
            int id = row.GetInt32(0);
            return new Folder(
                id,
                row.GetInt32(1),
                row.GetString(2),
                GetVideoFilesInFolder(id));
        }

        // get all video files associted with a given folder
        // the opposite of GetContainingFolder()
        public static List<VideoFile> GetVideoFilesInFolder(int folderId)
        {
            // get a list of file ids matching this folder as parent
            List<IDataRecord> data = Database.SimpleReadQuery(_fileLocationsTable,
                "folder_id", folderId.ToString());
            int[] fileIds = new int[data.Count];
            for(int i = 0; i < data.Count; i++)
            {
                fileIds[i] = data[0].GetInt32(0); 
            }
            // generate videofiles for them
            List<VideoFile> files = new List<VideoFile>();
            foreach (int id in fileIds)
            {
                files.Add(Files.GetFile(id));
            }
            return files;
        } 


        // clear the database of all folders and reset the hierarchy
        // setting a provided folder as root 
        // WARNING: silently kills the folders DB! BEWARE! 
        // does not kill file locations. to do that, call DeleteAllFiles() 
        // should probably only be called along with DeleteAllFiles() for that reason
        public static Response DeleteAllFolders(Folder newRoot)
        {
            Database.TruncateTable(_table);
            return AddFolder(newRoot, false); 
        }

        // TODO: folder tree implementation

    }
}