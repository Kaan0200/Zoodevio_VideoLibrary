/*
 * Represents a preference selection.
 * For example, defaulting to grid or library view.
 */

namespace Zoodevio.DataModel.Objects
{
    public class Preference
    {
        // the preference's id -- set by database
        public int Id { get;  }

        // the preference's name
        public string Name; 

        // the preference's data type in the DB
        // represented as a string because this is 
        // just about how to parse text data
        public string DataType;

        // the preference data
        public string Data; 
    }
}