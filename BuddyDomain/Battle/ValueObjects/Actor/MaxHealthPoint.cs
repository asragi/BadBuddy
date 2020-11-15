namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct MaxHealthPoint
    {
        public MaxHealthPoint(HealthPoint value)
        {
            MaxHealth = value;
        }

        public HealthPoint MaxHealth { get; }

        public string Display()
            => MaxHealth.Display();
    }
}
