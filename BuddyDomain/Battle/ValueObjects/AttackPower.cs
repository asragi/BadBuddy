using System;

namespace BuddyDomain.Battle.ValueObjects
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

        public void NotifyAttackPower(IAttackPowerListener listener)
            => listener.ListenAttackPower(value);
    }
}
