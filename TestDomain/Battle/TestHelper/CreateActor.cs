using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.ValueObjects.Actor;

namespace TestDomain.Battle.TestHelper
{
    public static class CreateActor
    {
        public static Actor Do()
            => new Actor(
                new ActorId("Test"),
                new ActorType("Test"),
                new MaxHealthPoint(new HealthPoint(500)),
                new HealthPoint(500),
                new Attack(50),
                new Speed(50),
                new Magic(50));

        public static Actor Do(ActorId id)
            => new Actor(
                id,
                new ActorType("Test"),
                new MaxHealthPoint(new HealthPoint(500)),
                new HealthPoint(500),
                new Attack(50),
                new Speed(50),
                new Magic(50));

        public static Actor Do(ActorId id, Speed speed)
            => new Actor(
                id,
                new ActorType("Test"),
                new MaxHealthPoint(new HealthPoint(500)),
                new HealthPoint(500),
                new Attack(50),
                speed,
                new Magic(50));
    }
}
