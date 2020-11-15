using BuddyDomain.Battle.Entities.Battle;
using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Repositories
{
    public interface ISkillRepository
    {
        Skill Find(SkillId skillId);
    }
}
