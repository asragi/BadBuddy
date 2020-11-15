using System.Collections.Generic;
using System.Linq;

namespace BuddyDomain.Entities.Battle
{
    public class Party
    {
        private readonly List<Actor> actors;

        public Party(IEnumerable<Actor> actors)
        {
            this.actors = actors.ToList();
        }
    }
}
