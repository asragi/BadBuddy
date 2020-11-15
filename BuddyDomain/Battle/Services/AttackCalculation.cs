using BuddyDomain.Battle.Repositories;
using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;
using BuddyDomain.Modules;
using BuddyDomain.Repositories;

namespace BuddyDomain.Battle.Services
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
            var attacker = actorRepository.Find(from);
            var victim = actorRepository.Find(to);
            var skill = skillRepository.Find(skillId);

            attacker.NotifyAttackFactor(attackPowerBuilder);
            skill.NotifyForceFactor(attackPowerBuilder);
            var attackPower = attackPowerBuilder.Build();

            var defenseRate = defenseRateBuilder.Build();

            attackPower.NotifyAttackPower(damageBuilder);
            defenseRate.NotifyDefenseRate(damageBuilder);
            return damageBuilder.Build();
        }
    }
}
