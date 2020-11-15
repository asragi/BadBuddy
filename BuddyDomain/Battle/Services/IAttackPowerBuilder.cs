using BuddyDomain.Battle.Entities;
using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services
{
    public interface IAttackPowerBuilder : IAttackNotification, IForceNotification
    {
        Damage Build();
    }
}
