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

    }
}