/*
 * Accessing and writing to preferences in the Zoodevio database.
 * Note that preferences are programmatic and never added/deleted,
 * only examined and modified. 
 */

using System;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    public static class Preferences
    {
        private static string _table = "preferences"; 
    
        public Preference Lookup(int id)
        {
            return null;
        }

        public Preference Lookup(string name)
        {
            return null;
        }

        public Boolean Modify(int id)
        {
            return null;
        }

    }
}