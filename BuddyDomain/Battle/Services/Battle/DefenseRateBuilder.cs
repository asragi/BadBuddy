using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services.Battle
{
    public class DefenseRateBuilder : IDefenseRateBuilder
    {
        public DefenseRate Build()
            => new DefenseRate(1);
    }
}
