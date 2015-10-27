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

        // add response codes, for adding files 
        // addsuccessful: the videofile was updated successfully
        // addfaileddatabase: the videofile couldn't be added to the DB (Connection issues?)
        // addfailedoverwrite: the videofile wasn't added because overwrite = false
        public enum AddResponses
        {
            AddSuccessful, AddFailedDatabase, AddFailedOverwrite
        }

        // add a file to the database 
        // returns a response code
        public static AddResponses AddFile(VideoFile file, Boolean overwrite)
        {
            // locate the video file if it exists
            VideoFile databaseFile = GetFile(file.Id);
            if (databaseFile == null)
            {
                // insert a new file if none exists
                Boolean success = Database.SimpleInsertQuery(_table, file.Path,
                    DateTime.Now.ToString(),
                    DateTime.Now.ToString());
                return (success) ? AddResponses.AddSuccessful : AddResponses.AddFailedDatabase;
            }
            else if (overwrite)
            {
                // overwrite the old file if overwrite true
                Boolean success = Database.SimpleUpdateQuery(_table, file.Id,
                    file.Path,
                    databaseFile.DateAdded,
                    DateTime.Now.ToString());
                return (success) ? AddResponses.AddSuccessful : AddResponses.AddFailedDatabase;
            }
            else
            {
                return AddResponses.AddFailedOverwrite;
            }
        }

        // add multiple files to the database
        // returns an array of response codes - one per file
        public static AddResponses[] AddFiles(List<VideoFile> files, Boolean overwrite)
        {
            AddResponses[] responses = new AddResponses[files.Count];
            for(int i = 0; i < files.Count; i++)
            {
                responses[i] = AddFile(files[i], overwrite);
            }
            return responses; 
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

    }
}
