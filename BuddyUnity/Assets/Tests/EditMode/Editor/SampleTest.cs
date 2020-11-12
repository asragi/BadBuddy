using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SampleTest
    {
        [Test]
        public void SampleTestSimplePasses()
        {
            Assert.AreEqual("Sample", Hello.Sample());
        }
    }
}
