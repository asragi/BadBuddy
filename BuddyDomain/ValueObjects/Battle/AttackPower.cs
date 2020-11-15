using System;

namespace BuddyDomain.ValueObjects.Battle
{
    public readonly struct AttackPower
    {
        private readonly int value;

        public AttackPower(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Attack power must be positive");
            }

            this.value = value;
        }
    }
}
