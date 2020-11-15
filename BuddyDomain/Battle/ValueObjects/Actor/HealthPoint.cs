using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct HealthPoint
    {
        private readonly int value;

        public HealthPoint(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("HP value must be positive or 0.");
            }

            this.value = value;
        }

        public static HealthPoint Zero => new HealthPoint(0);

        public bool Alive => this.value > 0;

        public HealthPoint Reduce(HealthPoint down)
        {
            int newerValue = Math.Max(0, this.value - down.value);
            return new HealthPoint(newerValue);
        }

        public HealthPoint Recover(HealthPoint inc, MaxHealthPoint max)
        {
            var refHp = max.MaxHealth;
            int after = Math.Min(refHp.value, this.value + inc.value);
            return new HealthPoint(after);
        }

        public string Display() => this.value.ToString();
    }
}
