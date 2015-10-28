using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel
{
    [TestFixture]
    public class Folder_Test
    {

        [Test]
        public void Folder_EmptyFolderConstructor_Accept()
        {
            var folder1 = new Folder(1, "Folder");
            //folder1 should have the parent 1 and the title "Title"
            Assert.True(folder1.ParentId == 1);
            Assert.True(folder1.Name == "Folder");
        }

        [Test]
        public void Folder_FolderWithFilesConstructor_Accept()
        {
            var folder1 = new Folder(1,0,"Folder",null);
            //folder1 should have parent 1, Id 0, title Folder and 
            //contain an empty list of video files
            Assert.True(folder1.Id == 1);
            Assert.True(folder1.ParentId == 0);
            Assert.True(folder1.Name == "Folder");
            Assert.True(folder1.Files == null);
        }
    }
}
