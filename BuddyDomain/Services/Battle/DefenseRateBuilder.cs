using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Services.Battle
{
    public class DefenseRateBuilder : IDefenseRateBuilder
    {
        public DefenseRate Build()
            => new DefenseRate(1);
    }
}
