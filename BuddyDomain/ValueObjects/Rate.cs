namespace BuddyDomain.ValueObjects
{
    public readonly struct Rate
    {
        private readonly float rate;

        public Rate(float rate)
            => this.rate = rate;

        public float Apply(float value)
            => value * rate;

        public float Apply(int value)
            => value * rate;
    }
}
