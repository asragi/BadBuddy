using BuddyDomain.ValueObjects.Battle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.ValueObjects.Battle
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
