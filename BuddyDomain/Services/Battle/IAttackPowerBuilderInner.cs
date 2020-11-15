using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Services.Battle
{
    public interface IAttackPowerBuilderInner : IAttackValueListener, IForceValueListener
    {
        AttackPower Build();
    }
}
