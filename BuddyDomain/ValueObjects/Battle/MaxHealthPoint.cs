namespace BuddyDomain.ValueObjects.Battle
{
    public readonly struct MaxHealthPoint
    {
        private readonly int value;

        public HealthPoint MaxHealth => new HealthPoint(value);
    }
}
