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
            var matches = ConvertDataTableToList(Database.SimpleReadQuery(_table,"id", id.ToString()));
            if (matches.Count > 0)
            {
                return matches[0];
            }
            else
            {
                return null;
            }
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

        private static List<Preference> ConvertDataTableToList(DataTable table)
        {
            List<Preference> returnList = new List<Preference>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                returnList.Add(new Preference(
                    Convert.ToInt32(row["id"]),
                    row["name"].ToString(),
                    row["data_type"].ToString(),
                    row["data"].ToString()
                    ));
            }
            return returnList;
        }
    }
}