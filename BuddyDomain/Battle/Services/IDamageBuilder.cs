using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Modules;

namespace BuddyDomain.Battle.Services
{
    public interface IDamageBuilder : IAttackPowerListener, IDefenseRateListener
    {
        Damage Build(IRandom random);
    }
}
