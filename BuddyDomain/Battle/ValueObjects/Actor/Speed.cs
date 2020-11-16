using System;

namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct Speed : IComparable<Speed>
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

        public static bool operator <(Speed a, Speed b)
            => a.CompareTo(b) < 0;

        public static bool operator >(Speed a, Speed b)
            => a.CompareTo(b) < 0;

        public int CompareTo(Speed other) => value.CompareTo(other.value);

    }
}
