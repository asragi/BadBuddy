using System;
using BuddyDomain.ValueObjects.Battle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.ValueObjects.Battle
{
    [TestClass]
    public class TestHealthPoint
    {
        [TestMethod]
        public void CheckEquals()
        {
            var first = new HealthPoint(100);
            var second = new HealthPoint(100);
            Assert.IsTrue(first == second);
            var third = new HealthPoint(200);
            Assert.IsFalse(first == third);
        }

        [TestMethod]
        public void ArgMustBePositive()
        {
            Action illegalNew = () => new HealthPoint(-1);
            Assert.ThrowsException<ArgumentException>(illegalNew);
        }

        [TestMethod]
        public void NonNegativeOnReduce()
        {
            var baseHealth = new HealthPoint(100);
            var minusHealth = new HealthPoint(200);
            var reduced = baseHealth.Reduce(minusHealth);
            Assert.IsTrue(reduced == HealthPoint.Zero);
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
