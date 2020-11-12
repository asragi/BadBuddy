using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(BuddyApplication.Class1.Test, 100);
        }
    }
}