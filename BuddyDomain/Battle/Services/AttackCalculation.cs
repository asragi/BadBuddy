using BuddyDomain.Battle.Repositories;
using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;
using BuddyDomain.Modules;
using BuddyDomain.Repositories;
using BuddyDomain.ValueObjects;

namespace BuddyDomain.Battle.Services
{
    public class AttackCalculation
    {
        private readonly IRandom random;
        private readonly Rate damageRate;
        private readonly IActorRepository actorRepository;
        private readonly ISkillRepository skillRepository;
        private readonly IAttackPowerBuilder attackPowerBuilder;
        private readonly IDefenseRateBuilder defenseRateBuilder;

        public AttackCalculation(
            IActorRepository actorRepository,
            ISkillRepository skillRepository,
            IAttackPowerBuilder attackPowerBuilder,
            IDefenseRateBuilder defenseRateBuilder,
            IRandom random,
            Rate damageRate)
        {
            this.actorRepository = actorRepository;
            this.skillRepository = skillRepository;
            this.random = random;
            this.attackPowerBuilder = attackPowerBuilder;
            this.defenseRateBuilder = defenseRateBuilder;
            this.damageRate = damageRate;
        }

        public Damage ExecuteCalculation(
            ActorId from,
            ActorId to,
            SkillId skillId)
        {
            var attacker = actorRepository.Find(from);
            var victim = actorRepository.Find(to);
            var skill = skillRepository.Find(skillId);

            // Build Base Damage
            attacker.NotifyAttackFactor(attackPowerBuilder);
            skill.NotifyForceFactor(attackPowerBuilder);
            var damage = attackPowerBuilder.Build();

            var defenseRate = defenseRateBuilder.Build();
            damage = damage.Multiply(defenseRate.GenerateRate());

            var randomRate = new Rate(random.Random());
            damage = damage.Multiply(randomRate);

            damage = damage.Multiply(damageRate);

            return damage;
        }
    }
}
