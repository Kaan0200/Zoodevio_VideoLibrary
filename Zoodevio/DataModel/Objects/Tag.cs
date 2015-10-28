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
        private string _dataType; 
        private int _id; 
        private bool _isModifiable;
        private bool _canSearch;
        private bool _canSort;
        private bool _required;

        // tags with some info for purposes of managing tags
        public Tag(string name, string databaseType, bool isModifiable)
        {
            _name = name;
            _dataType = databaseType;
            _isModifiable = isModifiable;
        }

        // tags with all info - for getting from database
        public Tag(int id, string name, bool canSearch, bool canSort, bool required,
            string dataType, bool isModifiable) : this(name, dataType, isModifiable)
        {
            _id = id; 
            _canSearch = canSearch;
            _canSort = canSort;
            _required = required;
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

        public int Id
        {
            get { return _id;  }
        }

        public string Name
        {
            get { return _name;  }
            set
            {
                if (IsModifiable)
                {
                    _name = value;
                }
            }
        }

        public string DataType
        {
            get { return _dataType;  }
            set
            {
                if (IsModifiable)
                {
                    _dataType = value; 
                }
            }
        }

        public bool IsModifiable
        {
            get { return _isModifiable;  }
        }

        public bool Required
        {
            get { return _required;  }
        }

        public bool CanSearch
        {
            get { return _canSearch; }
            set
            {
                if (IsModifiable)
                {
                    _canSearch = value; 
                }
            }

        }

        public bool CanSort
        {
            get { return _canSort; }
            set
            {
                if (IsModifiable)
                {
                    _canSort = value;
                }
            }

        }
        
        #endregion
    }
}