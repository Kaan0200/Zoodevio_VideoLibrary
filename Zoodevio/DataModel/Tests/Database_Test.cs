using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
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
            var rows = new String[] {"path", "date_added", "date_edited"};
            var data = new String[] {"path", "now", "now"};
            Assert.True(Database.SimpleInsertQuery("files", rows, data));
        }

        [Test]
        public void Database_SimpleUpdateQuery_Accept()
        {
            var rows = new String[] { "id", "path", "date_added", "date_edited" };
            var data = new String[] { "1", "path", "now", "now" };
            Assert.True(Database.SimpleUpdateQuery("files", "1", 1, rows, data));
        }

        [Test]
        public void Database_SimpleStarQuery_Accept()
        {
            //give the database some data
            var rows = new String[] { "id", "path", "date_added", "date_edited" };
            var data = new String[] { "1", "path", "now", "now" };
            Database.SimpleInsertQuery("files", rows, data);

            // execute the satr query on the data
            DataTable testTable = new DataTable();
            testTable = Database.SimpleStarQuery("files");

            //check if it worked
            DataTableReader reader = new DataTableReader(testTable);
            Assert.True((reader[0] + " ").Equals("1 path now now"));
        }

        [Test]
        public void Database_SimpleReadQuery_Accept()
        {
            //give the database some data
            //var rows = new String[] { "id", "path", "date_added", "date_edited" };
            //var data = new String[] { "1", "path", "now", "now" };
            //Database.SimpleInsertQuery("files", rows, data);

            // execute the read query on the data
            DataTable testTable = new DataTable();
            testTable = Database.SimpleReadQuery("files", "id", "1");

            //check if it worked
            DataTableReader reader = new DataTableReader(testTable);
            Assert.True((reader[0] + " ").Equals(@"1 C:\Users\hdizzle\Desktop\Zoodevio Library\attack on titan\Attack on Titan (Shingeki no Kyojin)  S01E16 What Should Be Done.mp4 11/13/2015 1:22:25 AM 11/13/2015 1:22:25 AM"));
        }

        [Test]
        public void Databse_ReadLikeQuery_Accept()
        {
            // execute the readLike query on the data
            DataTable testTable = new DataTable();
            testTable = Database.ReadLikeQuery("files", "id", "2", Database.LikeLocation.Before);

            //check if it worked
            DataTableReader reader = new DataTableReader(testTable);
            Assert.True((reader[0] + " ").Equals(@"1 C:\Users\hdizzle\Desktop\Zoodevio Library\attack on titan\Attack on Titan (Shingeki no Kyojin)  S01E16 What Should Be Done.mp4 11/13/2015 1:22:25 AM 11/13/2015 1:22:25 AM"));
        }

        [Test]
        public void Database_SimpleDeleteQuery_Accept()
        {
            //give the database some data
            //var rows = new String[] { "id", "path", "date_added", "date_edited" };
            //var data = new String[] { "1", "path", "now", "now" };
            //Database.SimpleInsertQuery("files", rows, data);

            //delte the information
            Assert.True(Database.SimpleDeleteQuery("files", "id", 1));
        }

    }
}
