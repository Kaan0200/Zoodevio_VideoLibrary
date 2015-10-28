using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel.Tests
{
    [TestFixture]
    class VideoFile_Test
    {

        [Test]
        public void VideoFile_NewFileEntry_Accept()
        {
            var videoFile1 = new VideoFile("path", null);
            Assert.True(videoFile1.Path == "path");
            Assert.True(videoFile1.Tags == null);
        }

        [Test]
        public void VideoFile_NewFileEntryWithData_Accept()
        {
            var testDateTime = DateTime.Now;
            var videoFile1 = new VideoFile(1, "path", null, testDateTime, testDateTime);
            Assert.True(videoFile1.Id == 1);
            Assert.True(videoFile1.Path == "path");
            Assert.True(videoFile1.Tags == null);
            Assert.True(videoFile1.DateAdded == testDateTime);
            Assert.True(videoFile1.DateEdited == testDateTime);
        }

    }
}
