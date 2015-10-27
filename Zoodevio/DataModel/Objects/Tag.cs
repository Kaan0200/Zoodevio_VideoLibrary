/*
 * Represents a type of tag in Zoodevio. 
 * Note that tag entries are handled in TagEntry.
 */ 
using System.Data;

namespace Zoodevio.DataModel.Objects
{
    public class Tag
    {
        private string _name;         // unique tag name
        private string _value;        // string value of the tag
        private DbType _databaseType; // type when stored in DB
        private bool _isModifiable;   

        // tags with full info for purposes of managing tags
        public Tag(string name, DbType databaseType, bool isModifiable)
        {
            Name = name;
            DatabaseType = databaseType;
            IsModifiable = isModifiable;
        }

        #region Variable Accessors
        //value's ability to be set is determined on if it can be modified
        public string Value
        {
            get { return _value; }
            set
            {
                if (IsModifiable)
                {
                    _value = value;
                }
            }
        }

        public string Name { get; }

        public DbType DatabaseType { get; }

        public bool IsModifiable { get; }

        #endregion
    }
}