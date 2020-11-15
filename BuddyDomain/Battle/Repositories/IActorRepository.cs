using BuddyDomain.Battle.Entities.Battle;
using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Repositories
{
    public interface IActorRepository
    {
        Actor Find(ActorId id);
    }
}
