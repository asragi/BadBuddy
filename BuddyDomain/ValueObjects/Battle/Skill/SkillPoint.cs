using System;

namespace BuddyDomain.ValueObjects.Battle.Skill
{
    public readonly struct SkillPoint
    {
        private readonly int value;

        public SkillPoint(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Value must be positive or 0.");
            }

            this.value = value;
        }

        public bool CheckRemain() => this.value > 0;

        public SkillPoint Consume()
        {
            int nextValue = Math.Max(0, this.value - 1);
            return new SkillPoint(nextValue);
        }
    }
}
