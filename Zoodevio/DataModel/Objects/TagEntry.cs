/* 
 * Represents a specific tag with certain data in it. 
 * Note that individual tags are handled by Tag.
 * Note: TagEntries do not know to which file they belong.
 * They also don't know what kind of data they hold.
 */ 
using System.Data;

namespace Zoodevio.DataModel.Objects
{

    public class TagEntry
    {
        public int Id;         // the ID of this tag in the DB
        // for speed, tagentries only know their type ID
        // their actual type is looked up later, when it's needed
        public int TypeId;
        public int FileId; // the file the tag belongs to
        public string Data; // the tag's data, unconverted



        // for creating a tag as part of a file
        public TagEntry(int typeId, string data)
        {
            TypeId = typeId;
            Data = data;
        }
        
        // for getting a tag from the db
        public TagEntry(int id, int typeId, int fileId, string data) : this(typeId, data)
        {
            Id = id;
            FileId = fileId;
        }
        // tags which are equal have the same type 
        // this is so that tags can be easily searched for and updated
        // please note: use EqualsWithData for real data equality
        public bool Equals(TagEntry tag)
        {
            if ((object) tag == null)
            {
                return false;
            }

            return (TypeId == tag.TypeId); 
        }

        // verifies that two tag objects represent the same exact tag in the database
        public bool isIdentical(TagEntry tag)
        {
            if ((object)tag == null)
            {
                return false;
            }

            return (TypeId == tag.TypeId) && (Id == tag.Id) && (Data.Equals(tag.Data)); 
        }



    }
}