using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Services.Battle
{
    public class AttackPowerBuilder : IAttackNotification, IForceNotification
    {
        private Attack attackRef;
        private Force forceRef;
        private AttackPowerValueBuilder attackPowerValueBuilder;

        public AttackPowerBuilder()
        {
            this.attackPowerValueBuilder = new AttackPowerValueBuilder();
        }

        public void AttackValue(Attack attack) => this.attackRef = attack;

        public void ForceValue(Force force) => this.forceRef = force;

        public AttackPower BuildPower()
        {
            this.attackRef.NotifyValue(this.attackPowerValueBuilder);
            this.forceRef.NotifyValue(this.attackPowerValueBuilder);
            return this.attackPowerValueBuilder.Build();
        }
    }
}
