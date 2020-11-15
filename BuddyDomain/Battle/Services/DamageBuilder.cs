using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Modules;

namespace BuddyDomain.Battle.Services
{
    public class DamageBuilder : IDamageBuilder
    {
        private int attackPower;
        private float defenseRate;

        public void ListenAttackPower(int power) => attackPower = power;

        public void ListenDefenseRate(float rate) => defenseRate = rate;

        public Damage Build(IRandom random)
        {
            float damage = random.Random() * attackPower * defenseRate;
            return new Damage((int)damage);
        }
    }
}
