using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Services.Battle
{
    public class AttackPowerValueBuilder : IAttackValueListener, IForceValueListener
    {
        private int attack;
        private int force;

        public AttackPower Build()
            => new AttackPower(this.attack * this.force);

        public void ListenAttackValue(int value) => this.attack = value;

        public void ListenForceValue(int value) => this.force = value;
    }
}
