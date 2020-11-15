using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Services.Battle
{
    public class DamageBuilder : IDamageBuilder
    {
        private int attackPower;
        private float defenseRate;

        public void ListenAttackPower(int power) => this.attackPower = power;

        public void ListenDefenseRate(float rate) => this.defenseRate = rate;

        public Damage Build()
            => new Damage((int)(this.attackPower * this.defenseRate));
    }
}
