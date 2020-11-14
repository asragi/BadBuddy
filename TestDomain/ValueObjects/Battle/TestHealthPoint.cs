using System;
using BuddyDomain.ValueObjects.Battle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.ValueObjects.Battle
{
    [TestClass]
    public class TestHealthPoint
    {
        [TestMethod]
        public void ArgMustBePositive()
        {
            static void IllegalNew() => new HealthPoint(-1);
            Assert.ThrowsException<ArgumentException>(IllegalNew);
        }

        [TestMethod]
        public void TestAlive()
        {
            var health = new HealthPoint(100);
            Assert.IsTrue(health.Alive);
        }

        [TestMethod]
        public void NonNegativeOnReduce()
        {
            var baseHealth = new HealthPoint(100);
            var minusHealth = new HealthPoint(1000);
            var maxHp = new MaxHealthPoint(baseHealth);
            var reduced = baseHealth.Reduce(minusHealth);
            var recovered = reduced.Recover(baseHealth, maxHp);
            Assert.IsTrue(recovered.Alive);
        }

        [TestMethod]
        public void DisplayTest()
        {
            var health = new HealthPoint(100);
            var text = health.Display();
            Assert.IsFalse(string.IsNullOrWhiteSpace(text));
        }
    }
}
