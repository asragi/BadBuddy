using System;
using BuddyDomain.ValueObjects;

namespace BuddyDomain.Battle.ValueObjects
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

        public void NotifyDamage(IDamageListener listener)
            => listener.ListenDamage(value);

        public Damage Multiply(Rate rate) => new Damage((int)rate.Apply(value));
    }
}
