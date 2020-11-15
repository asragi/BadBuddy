using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services
{
    public class DamageBuilder : IDamageBuilder
    {
        private int attackPower;
        private float defenseRate;

        public void ListenAttackPower(int power) => attackPower = power;

        public void ListenDefenseRate(float rate) => defenseRate = rate;

        public Damage Build()
            => new Damage((int)(attackPower * defenseRate));
    }
}
