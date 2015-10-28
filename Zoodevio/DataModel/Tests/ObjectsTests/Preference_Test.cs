using System;
using System.Data;
using NUnit.Framework;
using Zoodevio.DataModel.Objects;

namespace Zoodevio.DataModel.Tests
{

    [TestFixture]
    public class Preference_Test
    {

        [Test]
        public void Preference_PreferenceConstructor_Accept()
        {
            var prefferences = new Preference(1, "pref", "database type", "data");
            Assert.True(prefferences.Id == 1);
            Assert.True(prefferences.Name == "pref");
            Assert.True(prefferences.DataType == "database type");
            Assert.True(prefferences.Data == "data");
        }

    }
}
