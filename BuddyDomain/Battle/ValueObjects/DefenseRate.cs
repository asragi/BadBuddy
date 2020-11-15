using System;
using BuddyDomain.ValueObjects;

namespace BuddyDomain.Battle.ValueObjects
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

        public Rate GenerateRate() => new Rate(rate);
    }
}
