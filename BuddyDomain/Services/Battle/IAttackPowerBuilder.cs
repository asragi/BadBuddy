using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Services.Battle
{
    public interface IAttackPowerBuilder : IAttackNotification, IForceNotification
    {
        AttackPower Build();
    }
}
