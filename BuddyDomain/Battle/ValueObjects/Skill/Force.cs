using System;

namespace BuddyDomain.Battle.ValueObjects.Skill
{
    public readonly struct Force
    {
        private readonly int value;

        public Force(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Force must be positive.");
            }

            this.value = value;
        }

        public void NotifyValue(IForceValueListener listener)
            => listener.ListenForceValue(value);
    }
}
