using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Entities.Battle
{
    [TestClass]
    public class TestActor
    {
        [TestMethod]
        public void TestDieAndRevive()
        {
            var actor = CreateActor();
            Assert.IsTrue(actor.Alive);
            var damage = new HealthPoint(1000);
            actor.Damaged(damage);
            Assert.IsFalse(actor.Alive);
            var recover = new HealthPoint(1);
            actor.Recover(recover);
            Assert.IsTrue(actor.Alive);
        }

        private static Actor CreateActor()
        {
            var actorId = new ActorId("TestActor");
            var health = new HealthPoint(100);
            var max = new MaxHealthPoint(health);
            var attack = new Attack(50);
            var speed = new Speed(50);
            var magic = new Magic(50);
            return new Actor(actorId, max, health, attack, speed, magic);
        }
    }
}
