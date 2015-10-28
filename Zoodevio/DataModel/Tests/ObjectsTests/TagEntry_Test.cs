using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel.Tests
{
    [TestFixture]
    public class TagEntry_Test
    {

        [Test]
        public void TagEntry_TagEntryConstructor_Accept()
        {
            var tagEntry1 = new TagEntry(0, 1, 2, null);

            Assert.True(tagEntry1.Id == 0);
            Assert.True(tagEntry1.TypeId == 1);
            Assert.True(tagEntry1.FileId == 2);
            Assert.True(tagEntry1.Data == null);
        }

        [Test]
        public void TagEntry_TagEquals_Accept()
        {
            var tagEntry1 = new TagEntry(0, 1, 2, null);
            var tagEntry2 = new TagEntry(3, 1, 4, null);
            var tagEntry3 = new TagEntry(5, 6, 7, null);

            Assert.True(tagEntry1.Equals(tagEntry2));
            Assert.False(tagEntry1.Equals(tagEntry3));
            Assert.False(tagEntry1.Equals(null));
        }

        [Test]
        public void TageEntry_TagIdentical_Accept()
        {
            var data = new byte[] {0x20, 0x20};
            var tagEntry1 = new TagEntry(0, 1, 2, data);
            var tagEntry2 = new TagEntry(0, 1, 2, data);
            var tagEntry3 = new TagEntry(1, 1, 2, data);

            Assert.True(tagEntry1.isIdentical(tagEntry2));
            Assert.False(tagEntry1.isIdentical(tagEntry3));
            Assert.False(tagEntry1.isIdentical(null));
        }
    }
}
