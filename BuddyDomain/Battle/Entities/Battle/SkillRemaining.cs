using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Battle.Entities.Battle
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
