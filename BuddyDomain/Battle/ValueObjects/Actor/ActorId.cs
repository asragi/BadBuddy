using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public struct ActorId : IEquatable<ActorId>
    {
        private readonly string id;

        public ActorId(string id)
        {
            this.id = id;
        }

        public static bool operator ==(ActorId a, ActorId b) => a.Equals(b);

        public static bool operator !=(ActorId a, ActorId b) => !(a == b);

        public bool Equals(ActorId other) => id == other.id;

        public override bool Equals(object obj) => obj is ActorId other && Equals(other);

        public override int GetHashCode() => id != null ? id.GetHashCode() : 0;
    }
}
