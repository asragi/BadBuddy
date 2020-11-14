using BuddyDomain.ValueObjects.Battle.Actor;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Entities.Battle
{
    public class SkillRemaining
    {
        private readonly SkillId skillId;
        private readonly ActorId actorId;
        private SkillPoint skillPoint;

        public SkillRemaining(
            SkillId skillId,
            ActorId actorId,
            SkillPoint skillPoint)
        {
            this.skillId = skillId;
            this.actorId = actorId;
            this.skillPoint = skillPoint;
        }

        public bool CheckRemain()
            => this.skillPoint.CheckRemain();

        public void Consume()
            => this.skillPoint = this.skillPoint.Consume();
    }
}
