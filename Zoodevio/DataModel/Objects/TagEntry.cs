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
        public byte[] Data; // the tag's data, unconverted

        public TagEntry(int id, int typeID, int fileID, byte[] data)
        {
            Id = id;
            TypeId = typeID;
            FileId = fileID; 
            Data = data;
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