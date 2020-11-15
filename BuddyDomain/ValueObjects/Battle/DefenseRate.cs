using System;

namespace BuddyDomain.ValueObjects.Battle
{
    public readonly struct DefenseRate
    {
        private readonly float rate;

        public DefenseRate(float rate)
        {
            if (rate < 0)
            {
                throw new ArgumentException("Defense rate must be positive or 0.");
            }

            this.rate = rate;
        }
    }
}
