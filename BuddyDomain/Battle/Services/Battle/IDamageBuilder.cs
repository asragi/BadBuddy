using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services.Battle
{
    public interface IDamageBuilder : IAttackPowerListener, IDefenseRateListener
    {
        Damage Build();
    }
}
