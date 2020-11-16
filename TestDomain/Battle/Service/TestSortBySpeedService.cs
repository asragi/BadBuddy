using System.Collections.Generic;
using System.Linq;
using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.Repositories;
using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestDomain.Battle.TestHelper;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestSortBySpeedService
    {
        [TestMethod]
        public void TestSort()
        {
            var slowId = new ActorId("slow");
            var fastId = new ActorId("fast");
            var standardId = new ActorId("Standard");
            var slowerActor = CreateActor.Do(slowId, new Speed(49));
            var fasterActor = CreateActor.Do(fastId, new Speed(51));
            var standardActor = CreateActor.Do(standardId, new Speed(50));

            var actorRepository = new Mock<IActorRepository>();
            actorRepository.Setup(
                    repo => repo.FindIn(It.IsAny<IEnumerable<ActorId>>()))
                .Returns(new[] { slowerActor, fasterActor, standardActor });

            var sortService = new SortBySpeedService(actorRepository.Object);

            var result = sortService.Sort(new[] { slowId, fastId, standardId });
            var expected = new List<ActorId> { fastId, standardId, slowId };
            Assert.AreEqual(expected.Count, result.Count);
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
