using System.Collections.Generic;

namespace BuddyDomain.Battle.Entities
{
    public interface IPartyMemberListener
    {
        void ListenMember(IEnumerable<Actor> actors);
    }
}
