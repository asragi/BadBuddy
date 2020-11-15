using BuddyDomain.Battle.Entities.Battle;
using BuddyDomain.Battle.ValueObjects.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Battle.Entities
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
            var actorType = new ActorType("TestActor");
            var health = new HealthPoint(100);
            var max = new MaxHealthPoint(health);
            var attack = new Attack(50);
            var speed = new Speed(50);
            var magic = new Magic(50);
            return new Actor(actorId, actorType, max, health, attack, speed, magic);
        }
    }
}
