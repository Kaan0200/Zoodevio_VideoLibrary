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

        // add a file to the database 
        // returns true if successful, false otherwise
        // TODO 
        public static Boolean AddFile(VideoFile file)
        {
            return false;
        }

        // add multiple files to the database
        // returns -1 if all files added successfully
        // otherwise, returns the index of the failed file 
        // TODO
        public static int AddFiles(List<VideoFile> files)
        {
            return 0;
        }

        // get all file object(s) in the database that have a certain path
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
        private static VideoFile VideoFileFromRecord(IDataRecord row)
        {
            int id = row.GetInt32(0); 
            return new VideoFile(
                id,
                row.GetString(1),
                Tags.GetFileTags(id),
                Convert.ToDateTime(row.GetDateTime(2)),
                Convert.ToDateTime(row.GetDateTime(3)));
        }

    }
}
