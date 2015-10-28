using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    /* This is the testing class for Tags */
    [TestFixture]
    public class Tag_Test
    {
        /* Note: You do not need to comment the methods,
        I wrote a lot of comments for the first one as a template.
        Put [Test] ontop of every method to mark it as a test for the runner*/

        [Test]
        // The format of test method names should be 
        // {Object Being Tested}_{Testing what?}_{Result}
        public void Tag_ModifyTitleTag_Accept()
        {
            var tag1 = new Tag("Title", "DbType", true); 
            tag1.Name = "Chronicals Of Riddick";
            // we should be able to modify tags, so when pulling back the value it should be changed

            Assert.True(tag1.Name == "Chronicals Of Riddick");
        }

        [Test]
        public void Tag_ModifyDataTypeTag_Accept()
        {
            var tag1 = new Tag("Title", "DbType", true);
            tag1.DataType = "OtherDbType";
            // we should be able to modify tags, so when pulling back the value it should be changed

            Assert.True(tag1.DataType == "OtherDbType");
        }

        [Test]
        public void Tag_NotModifyTitleTag_Accept()
        {
            var tag1 = new Tag("Title", "DbType", false);
            tag1.Name = "Chronicals Of Riddick";
            // we should be able to modify tags, so when pulling back the value it should be changed

            Assert.True(tag1.Name == "Title");
        }

        [Test]
        public void Tag_GetNameTag_Accept()
        {
            var tag1 = new Tag("Title", "DbType", true);
            Assert.True(tag1.Name == "Title");
        }

        [Test]
        public void Tag_GetDatabaseType_Accept()
        {
            var tag1 = new Tag("Filetype", "DbType", false);
            Assert.True(tag1.DataType == "DbType");
        }
    }
}