using BuddyDomain.Battle.Entities.Battle;
using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services.Battle
{
    public interface IAttackPowerBuilder : IAttackNotification, IForceNotification
    {
        AttackPower Build();
    }
}
