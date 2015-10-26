﻿using System;
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
            var tag1 = new Tag("Title", DbType.String, true); 
            tag1.Value = "Chronicals Of Riddick";
            // we should be able to modify tags, so when pulling back the value it should be changed

            Assert.True(tag1.Value == "Chronicals Of Riddick");
        }
    }
}