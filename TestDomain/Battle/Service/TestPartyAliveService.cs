using System.Collections.Generic;
using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.Repositories;
using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestPartyAliveService
    {
        [TestMethod]
        public void CheckWipedOut()
        {
            var actorAId = new ActorId("A");
            var actorBId = new ActorId("B");
            var actorA = CreateActor(actorAId, new HealthPoint(0));
            var actorB = CreateActor(actorBId, new HealthPoint(0));

            var party = new Party(new[] { actorAId, actorBId });

            var actorsBuilder = new Mock<IPartyActorsBuilder>();
            actorsBuilder.Setup(b => b.Fetch())
                .Returns(new List<Actor> { actorA, actorB });
            var partyAliveService = new PartyAliveService(actorsBuilder.Object);
            Assert.IsTrue(partyAliveService.CheckWipedOut(party));
        }

        [TestMethod]
        public void CheckNotWipedOut()
        {
            var actorAId = new ActorId("A");
            var actorBId = new ActorId("B");
            var actorA = CreateActor(actorAId, new HealthPoint(1));
            var actorB = CreateActor(actorBId, new HealthPoint(0));

            var party = new Party(new[] { actorAId, actorBId });

            var actorsBuilder = new Mock<IPartyActorsBuilder>();
            actorsBuilder.Setup(b => b.Fetch())
                .Returns(new List<Actor> { actorA, actorB });
            var partyAliveService = new PartyAliveService(actorsBuilder.Object);
            Assert.IsFalse(partyAliveService.CheckWipedOut(party));
        }

        private static Actor CreateActor(
            ActorId id,
            HealthPoint hp) =>
            new Actor(
                id,
                new ActorType("Test"),
                new MaxHealthPoint(new HealthPoint(500)),
                hp,
                new Attack(50),
                new Speed(59),
                new Magic(50));
    }
}
