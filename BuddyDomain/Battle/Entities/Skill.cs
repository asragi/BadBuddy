using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Battle.Entities
{
    public class Skill
    {
        private readonly SkillId id;
        private readonly Target target;
        private readonly Force force;
        private readonly SkillPoint skillPoint;

        public Skill(
            SkillId id,
            Target target,
            Force force,
            SkillPoint point)
        {
            this.id = id;
            this.target = target;
            this.force = force;
            skillPoint = point;
        }

        public void NotifyForceFactor(IForceNotification notification)
        {
            notification.ForceValue(force);
        }
    }
}
