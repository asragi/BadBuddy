using System;

namespace BuddyDomain.ValueObjects.Battle
{
    public readonly struct Attack
    {
        private readonly int value;

        public Attack(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Attack value must be positive.");
            }

            this.value = value;
        }
    }
}
