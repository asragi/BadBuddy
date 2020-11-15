using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public struct ActorType
    {
        private readonly string value;

        public ActorType(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ActorType should have text");
            }

            this.value = value;
        }
    }
}
