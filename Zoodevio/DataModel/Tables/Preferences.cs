/*
 * Accessing and writing to preferences in the Zoodevio database.
 * Note that preferences are programmatic and never added/deleted,
 * only examined and modified. 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Preferences
    {
        private static string _table = "preferences"; 
    
        // lookup is only by ID because preference
        // names are not necessarily unique/canonical
        // they are just for user comprehension
        public static Preference Lookup(int id)
        {
             return ConvertReaderToPreference(Database.SimpleReadQuery(_table,"id", id.ToString()));
        }

        private static Preference ConvertReaderToPreference(SQLiteDataReader reader)
        {
            Preference returnPref = null;
            while (reader.Read())
            {
                returnPref = new Preference(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }
            return returnPref;
        }

        // only the data of a preference is ever modified
        // the rest is specified by design doc
        public static bool Modify(int id, string data)
        {
            string[] rows = {"data"};
            string[] dbData = new string[1];
            dbData[0] = data;
            return Database.SimpleUpdateQuery(_table, "id", id,
                rows, dbData); 
        }

    }
}