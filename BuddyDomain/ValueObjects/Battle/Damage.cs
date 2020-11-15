using System;

namespace BuddyDomain.ValueObjects.Battle
{
    public readonly struct Damage
    {
        private readonly int value;

        public Damage(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Damage must be positive.");
            }

            this.value = value;
        }
    }
}
