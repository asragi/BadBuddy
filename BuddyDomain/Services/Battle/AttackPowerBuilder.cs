using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Services.Battle
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

        public void AttackValue(Attack attack) => this.attackRef = attack;

        public void ForceValue(Force force) => this.forceRef = force;

        public AttackPower Build()
        {
            this.attackRef.NotifyValue(this.attackPowerBuilderInner);
            this.forceRef.NotifyValue(this.attackPowerBuilderInner);
            return this.attackPowerBuilderInner.Build();
        }
    }
}
