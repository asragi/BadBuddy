using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Services.Battle
{
    public class AttackPowerBuilderInner : IAttackPowerBuilderInner
    {
        private int attack;
        private int force;

        public AttackPower Build()
            => new AttackPower(this.attack * this.force);

        public void ListenAttackValue(int value) => this.attack = value;

        public void ListenForceValue(int value) => this.force = value;
    }
}
