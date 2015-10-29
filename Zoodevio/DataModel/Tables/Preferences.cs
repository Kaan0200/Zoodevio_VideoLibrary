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
            //TODO: protect from empty dt returns
            var dt = Database.SimpleReadQuery(_table,"id", id.ToString());
            return new Preference(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
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