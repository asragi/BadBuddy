using System.Collections.Generic;
using System.Linq;
using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Entities
{
    public class Party
    {
        private readonly List<ActorId> actors;

        public Party(IEnumerable<ActorId> actors)
        {
            this.actors = actors.ToList();
        }
    }
}
