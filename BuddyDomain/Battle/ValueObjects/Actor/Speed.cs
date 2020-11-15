using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct Speed
    {
        private readonly int value;

        public Speed(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Value must be positive.");
            }

            this.value = value;
        }
    }
}