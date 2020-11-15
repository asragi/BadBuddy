using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Battle.Entities.Battle
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
            this.skillPoint = point;
        }

        public void NotifyForceFactor(IForceNotification notification)
        {
            notification.ForceValue(this.force);
        }
    }
}
