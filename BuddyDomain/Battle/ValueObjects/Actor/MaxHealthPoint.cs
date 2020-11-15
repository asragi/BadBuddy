namespace BuddyDomain.Battle.ValueObjects.Actor
{
    public readonly struct MaxHealthPoint
    {
        public MaxHealthPoint(HealthPoint value)
        {
            this.MaxHealth = value;
        }

        public HealthPoint MaxHealth { get; }

        public string Display()
            => this.MaxHealth.Display();
    }
}
