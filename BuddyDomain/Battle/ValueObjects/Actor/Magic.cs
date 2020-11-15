using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct Magic
    {
        private readonly int value;

        public Magic(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Value must be positive.");
            }

            this.value = value;
        }
    }
}
