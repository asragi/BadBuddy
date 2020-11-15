using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services
{
    public interface IDamageBuilder : IAttackPowerListener, IDefenseRateListener
    {
        Damage Build();
    }
}
