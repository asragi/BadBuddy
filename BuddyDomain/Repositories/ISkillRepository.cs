using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Repositories
{
    public interface ISkillRepository
    {
        Skill Find(SkillId skillId);
    }
}
