using System.Collections.Generic;
using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Repositories
{
    public interface IActorRepository
    {
        Actor Find(ActorId id);

        IEnumerable<Actor> FindIn(IEnumerable<ActorId> ids);
    }
}
