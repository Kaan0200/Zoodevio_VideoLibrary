/*
 * Accessing and writing to preferences in the Zoodevio database.
 * Note that preferences are programmatic and never added/deleted,
 * only examined and modified. 
 */

using System;
using System.Collections.Generic;
using System.Data;
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
            List<IDataRecord> data = Database.SimpleReadQuery(_table,
                "id", id.ToString());
            if (data.Count == 0)
            {
                return null; 
            }
            IDataRecord row = data[0];
            return new Preference(
                row.GetInt32(0),
                row.GetString(1),
                row.GetString(2),
                row.GetString(3)
                );
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