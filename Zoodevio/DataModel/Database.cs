/*
 * Accesses and executes direct queries to the Zoodevio database.
 * This is an SQLite database, database.sqlite, located in
 * the Zoodevio installation. 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Zoodevio.DataModel
{
    public static class Database
    {

        // location codes for LIKE queries
        public enum LikeLocation
        {
            Before,
            After,
            Both
        }

        // the database filename
        // never changed while Zoodevio is executing
        // in the future, perhaps could be read from an ini or registry key? 
        private const string DATABASE_FILE = "database.sqlite";

        // the SQLite connection. all database access is done through this class
        // so this connection is private.
        private static SQLiteConnection _dbConnection = new SQLiteConnection(
            "Data Source=" + DATABASE_FILE + ";Version=3;PRAGMA foreign_keys = 1");

        // executes a basic read query (select * from table where column is value) 
        public static List<IDataRecord> SimpleReadQuery(string table, string column, string value)
        {
            List<IDataRecord> data = new List<IDataRecord>();
            // build the query
            SQLiteCommand com =
                new SQLiteCommand("select * from '" + table + "' where '" + column + "' = '" + value + "'");
            return ConvertReaderRows(com.ExecuteReader());

        }

        // iterate over a data reader object
        private static IEnumerable<IDataRecord> GetFromReader(IDataReader reader)
        {
            while (reader.Read()) yield return reader;
        }

        // get raw bytes of data from a row (for reading blobs) 
        // adapted from stackoverflow #625029
        public static byte[] GetBytes(IDataRecord row, int field)
        {
            const int CHUNK_SIZE = 2*1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = row.GetBytes(field, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int) bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }

        // perform a LIKE query on a given database for a given column/input string
        public static List<IDataRecord> ReadLikeQuery(string table, string column, string value, LikeLocation loc)
        {
            string valueWithWildcards = GetWildcardedString(value, loc);
            SQLiteCommand com =
                new SQLiteCommand("select * from '" + table + "' where '" + column + "' = '" + value + "'");
            return ConvertReaderRows(com.ExecuteReader());

        }

        // get the LIKE string for a given string, based on where the like wildcards should be
        private static string GetWildcardedString(string value, LikeLocation loc)
        {
            switch (loc)
            {
                case LikeLocation.Before:
                    return "%" + value;
                case LikeLocation.After:
                    return value + "%";
                case LikeLocation.Both:
                    return "%" + value + "%";
                default:
                    throw new ArgumentException("invalid LikeLocation provided!");
            }
        }

        // convert reader records into a data record list for easy iteration
        private static List<IDataRecord> ConvertReaderRows(SQLiteDataReader reader)
        {
            // iterate over the reader and get each row
            // might be a better way than this but I don't know enough C# mojo 
            List<IDataRecord> data = new List<IDataRecord>();
            foreach (IDataRecord record in GetFromReader(reader))
            {
                data.Add(record);
            }
            return data;
        }

        // TODO: add write queries

    }
}