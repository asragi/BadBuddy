using System;

namespace BuddyDomain.Battle.ValueObjects.Skill
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

        public bool CheckRemain() => value > 0;

        public SkillPoint Consume()
        {
            int nextValue = Math.Max(0, value - 1);
            return new SkillPoint(nextValue);
        }
    }
}
