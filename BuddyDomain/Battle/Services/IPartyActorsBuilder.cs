using System.Collections.Generic;
using BuddyDomain.Battle.Entities;

namespace BuddyDomain.Battle.Services
{
    public interface IPartyActorsBuilder : IPartyMemberListener
    {
        List<Actor> Fetch();
    }
}
