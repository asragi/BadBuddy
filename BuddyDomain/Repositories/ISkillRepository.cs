using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Repositories
{
    public interface ISkillRepository
    {
        Skill Find(SkillId skillId);
    }
}
