using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;

namespace BuddyDomain.Battle.Services
{
    public class AttackPowerBuilder : IAttackPowerBuilder
    {
        private readonly IAttackPowerBuilderInner attackPowerBuilderInner;
        private Attack attackRef;
        private Force forceRef;

        public AttackPowerBuilder(IAttackPowerBuilderInner attackPowerBuilderInner)
        {
            this.attackPowerBuilderInner = attackPowerBuilderInner;
        }

        public void AttackValue(Attack attack) => attackRef = attack;

        public void ForceValue(Force force) => forceRef = force;

        public AttackPower Build()
        {
            attackRef.NotifyValue(attackPowerBuilderInner);
            forceRef.NotifyValue(attackPowerBuilderInner);
            return attackPowerBuilderInner.Build();
        }
    }
}
