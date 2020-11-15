using BuddyDomain.Battle.ValueObjects.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Battle.ValueObjects.Actor
{
    [TestClass]
    public class TestMaxHealthPoint
    {
        [TestMethod]
        public void DisplayMaxHealthPoint()
        {
            var health = new HealthPoint(100);
            var max = new MaxHealthPoint(health);
            Assert.IsFalse(string.IsNullOrWhiteSpace(max.Display()));
        }
    }
}
