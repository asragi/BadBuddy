namespace BuddyDomain.ValueObjects.Battle.Skill
{
    public readonly struct Target
    {
        private readonly TargetEnum target;

        public Target(TargetEnum target)
        {
            this.target = target;
        }
    }
}
