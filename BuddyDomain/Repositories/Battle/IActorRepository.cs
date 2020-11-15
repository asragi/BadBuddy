using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;

namespace BuddyDomain.Repositories.Battle
{
    public interface IActorRepository
    {
        Actor Find(ActorId id);
    }
}
