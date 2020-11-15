using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Battle.Services.Battle
{
    public interface IAttackPowerBuilderInner : IAttackValueListener, IForceValueListener
    {
        AttackPower Build();
    }
}
