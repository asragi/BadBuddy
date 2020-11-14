namespace BuddyDomain.ValueObjects.Battle
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
