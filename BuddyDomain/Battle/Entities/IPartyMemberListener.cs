using System.Collections.Generic;
using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Entities
{
    public interface IPartyMemberListener
    {
        void ListenMember(IEnumerable<ActorId> actors);
    }
}
