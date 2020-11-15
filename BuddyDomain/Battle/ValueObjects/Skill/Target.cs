namespace BuddyDomain.Battle.ValueObjects.Skill
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
