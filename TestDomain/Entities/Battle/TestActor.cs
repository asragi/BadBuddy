using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Entities.Battle
{
    [TestClass]
    public class TestActor
    {
        [TestMethod]
        public void TestDieAndRevive()
        {
            var health = new HealthPoint(100);
            var max = new MaxHealthPoint(health);
            var actor = new Actor(max, health);
            Assert.IsTrue(actor.Alive);
            var damage = new HealthPoint(1000);
            actor.Damaged(damage);
            Assert.IsFalse(actor.Alive);
            var recover = new HealthPoint(1);
            actor.Recover(recover);
            Assert.IsTrue(actor.Alive);
        }
    }
}
