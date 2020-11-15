using BuddyDomain.Battle.ValueObjects;

namespace BuddyDomain.Battle.Services
{
    public class AttackPowerBuilderInner : IAttackPowerBuilderInner
    {
        private int attack;
        private int force;

        public AttackPower Build()
            => new AttackPower(attack * force);

        public void ListenAttackValue(int value) => attack = value;

        public void ListenForceValue(int value) => force = value;
    }
}
