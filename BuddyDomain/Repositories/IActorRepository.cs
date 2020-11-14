using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;

namespace BuddyDomain.Repositories
{
    public interface IActorRepository
    {
        Actor Find(ActorId id);
    }
}
