using BuddyDomain.Battle.Repositories;
using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;
using BuddyDomain.Modules;
using BuddyDomain.Repositories;

namespace BuddyDomain.Battle.Services.Battle
{
    public class AttackCalculation
    {
        private readonly IRandom random;
        private readonly IActorRepository actorRepository;
        private readonly ISkillRepository skillRepository;
        private readonly IAttackPowerBuilder attackPowerBuilder;
        private readonly IDefenseRateBuilder defenseRateBuilder;
        private readonly IDamageBuilder damageBuilder;

        public AttackCalculation(
            IActorRepository actorRepository,
            ISkillRepository skillRepository,
            IAttackPowerBuilder attackPowerBuilder,
            IDefenseRateBuilder defenseRateBuilder,
            IDamageBuilder damageBuilder,
            IRandom random)
        {
            this.actorRepository = actorRepository;
            this.skillRepository = skillRepository;
            this.random = random;
            this.attackPowerBuilder = attackPowerBuilder;
            this.defenseRateBuilder = defenseRateBuilder;
            this.damageBuilder = damageBuilder;
        }

        public Damage ExecuteCalculation(
            ActorId from,
            ActorId to,
            SkillId skillId)
        {
            var attacker = this.actorRepository.Find(from);
            var victim = this.actorRepository.Find(to);
            var skill = this.skillRepository.Find(skillId);

            attacker.NotifyAttackFactor(this.attackPowerBuilder);
            skill.NotifyForceFactor(this.attackPowerBuilder);
            var attackPower = this.attackPowerBuilder.Build();

            var defenseRate = this.defenseRateBuilder.Build();

            attackPower.NotifyAttackPower(this.damageBuilder);
            defenseRate.NotifyDefenseRate(this.damageBuilder);
            return this.damageBuilder.Build();
        }
    }
}
