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
using System.Net;
using System.Reflection;
using System.Xml;
using NUnit.Framework;

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

        // the default id and parent id for the root folder
        public static readonly int ROOT_ID = 1;
        public static readonly int ROOT_PARENT = 0;

        // the directory where Zoodevio is executing
        private static readonly string PROJECT_DIRECTORY = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // the database filename
        // never changed while Zoodevio is executing
        // in the future, perhaps could be read from an ini or registry key? 
        private static readonly string DATABASE_FILE = PROJECT_DIRECTORY + "\\..\\..\\database.sqlite";

        // the SQLite connection. all database access is done through this class
        // so this connection is private.
        private static SQLiteConnection _dbConnection = new SQLiteConnection(
            "Data Source=" + DATABASE_FILE + ";Version=3;PRAGMA foreign_keys = 1");

        // executes a basic select * query from a table
        public static DataTable SimpleStarQuery(string table)
        {
            DataTable dt = new DataTable();
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            List<IDataRecord> data = new List<IDataRecord>();
            // build the query
            SQLiteCommand com = new SQLiteCommand("select * from " + table, _dbConnection);
            dt.Load(com.ExecuteReader());
            _dbConnection.Close();
            return dt;
        }

        // executes a basic read query (select * from table where column is value) 
        public static DataTable SimpleReadQuery(string table, string column, string value)
        {
            value = value.Replace("'", "''");
            DataTable dt = new DataTable();
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open(); 
            List<IDataRecord> data = new List<IDataRecord>();
            // build the query
            SQLiteCommand com =
                new SQLiteCommand("select * from " + table + " where " + column + " = " + value , _dbConnection);
            dt.Load(com.ExecuteReader());
            _dbConnection.Close();
            return dt;
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
        public static DataTable ReadLikeQuery(string table, string column, string value, LikeLocation loc)
        {
            value = value.Replace("'", "''");
            DataTable dt = new DataTable();
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            SQLiteCommand com =
                new SQLiteCommand("select * from " + table + " where " + column + " LIKE '" + GetWildcardedString(value, loc) + "'", _dbConnection);
            dt.Load(com.ExecuteReader());
            _dbConnection.Close();
            return dt;

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

        // insert a new record into the database; return success or failure
        // note: data string should be formatted correctly (ints without quotes, etc.)
        public static bool SimpleInsertQuery(string table, 
            string[] rows, string[] data)
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            string rowStatement = String.Join(", ", rows);
            string dataStatement = String.Join("', '", SanitizeData(data));
            string query = "insert into " + table + " (" + rowStatement + ") values ('" + dataStatement + "')";
            Console.Write(query);
            // sanitize for apostrophes
            SQLiteCommand com = new SQLiteCommand(query,_dbConnection);
            try
            {
                com.ExecuteNonQuery();
                _dbConnection.Close(); 
                return true;
            }
            catch(Exception e)
            {
                _dbConnection.Close();
                Console.Write(e.ToString());
                return false;
            }
        }

        // update a record with new values in the database; return success or failure
        // note: data string should be formatted correctly (ints without quotes, etc.)
        public static bool SimpleUpdateQuery(string table, string identifierField, object identifier,
            string[] rows, string[] data)
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            string setCommand = BuildSetCommand(rows, SanitizeData(data));
            // sanitize for apostrophes
            string query = "update " + table + " set " + setCommand + " WHERE " + identifierField + " = '" + identifier + "'";
            Console.WriteLine(query);
            SQLiteCommand com = new SQLiteCommand(query,_dbConnection);
            try
            {
                com.ExecuteNonQuery();
                _dbConnection.Close();
                return true;
            }
            catch(Exception e)
            {
                _dbConnection.Close();
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        // sanitize data rows
        private static string[] SanitizeData(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = data[i].Replace("'", "''");
            }
            return data;
        }

        // builds a SET statement with a list of columns to set up 
        private static string BuildSetCommand(string[] rows, string[] data)
        {
            string output = "";
            for(int i = 0; i < rows.Length; i++)
            {
                output += rows[i] + " = '" + data[i] + "'";
                if (i < rows.Length - 1)
                {
                    output += ", "; 
                }
            }
            return output; 
        }

        // deletes a row from the database
        // returns true if successful, false if failed
        public static bool SimpleDeleteQuery(string table, string identifier, int id)
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            SQLiteCommand com = new SQLiteCommand("delete from " + table + " where " + identifier + " = " + id, _dbConnection);
            try
            {
                com.ExecuteNonQuery();
                _dbConnection.Close();
                return true;
            }
            catch
            {
                _dbConnection.Close();
                return false; 
            }
        }

        // truncates a database table
        // WARNING: THIS KILLS THE TABLE (silently)
        // if resetIncrement is true, also restarts the id increment at 0
        public static bool TruncateTable(string table, bool resetIncrement)
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            string query = "delete from " + table + "; vacuum" + ((resetIncrement) ? "; delete from sqlite_sequence where name='" + table + "'" : "");
            Console.Write(query + "\n");
            SQLiteCommand com = new SQLiteCommand(query, _dbConnection);
            try
            {
                com.ExecuteNonQuery();
                _dbConnection.Close();
                return true;
            }
            catch
            {
                _dbConnection.Close();
                return false;
            }
        }

        // get the ID of the last item inserted into a given table
        // note: this returns the integer id associated with the last inserted rowid; though theoretically these values are the same
        // they may be different
        public static int GetLastInsertID(string table)
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
            _dbConnection.Open();
            string query = "select max(id) from "+table;
            Console.Write(query + "\n");
            SQLiteCommand com = new SQLiteCommand(query, _dbConnection);
            try
            {
                int id = Convert.ToInt32(com.ExecuteScalar()); 
                _dbConnection.Close();
                return id; 
            }
            catch
            {
                _dbConnection.Close();
                return -1;
            }
        }
    }
}