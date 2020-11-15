using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Services.Battle
{
    public interface IDamageBuilder : IAttackPowerListener, IDefenseRateListener
    {
        Damage Build();
    }
}
