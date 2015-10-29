using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel.Tests
{
    [TestFixture]
    class Database_Test
    {

        [Test]
        public void Database_SimpleInsertQuery_Accept()
        {
            var rows = new String[] {"id", "path", "date_added", "date_edited"};
            var data = new String[] {"1", "path", "now", "now"};
            Assert.True(Database.SimpleInsertQuery("files", rows, data));
        }

        [Test]
        public void Database_SimpleUpdateQuery_Accept()
        {
            var rows = new String[] { "id", "path", "date_added", "date_edited" };
            var data = new String[] { "1", "path", "now", "now" };
            Assert.True(Database.SimpleUpdateQuery("files", "1", 1, rows, data));
        }

    }
}
