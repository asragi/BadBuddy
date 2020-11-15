using BuddyDomain.Modules;
using BuddyDomain.Repositories;
using BuddyDomain.Repositories.Battle;
using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;
using BuddyDomain.ValueObjects.Battle.Skill;

namespace BuddyDomain.Services.Battle
{
    public class AttackCalculation
    {
        private readonly IRandom random;
        private readonly IActorRepository actorRepository;
        private readonly ISkillRepository skillRepository;
        private readonly AttackPowerBuilder attackPowerBuilder;
        private readonly DefenseRateBuilder defenseRateBuilder;
        private readonly DamageBuilder damageBuilder;

        public AttackCalculation(
            IActorRepository actorRepository,
            ISkillRepository skillRepository,
            IRandom random)
        {
            this.actorRepository = actorRepository;
            this.skillRepository = skillRepository;
            this.random = random;
            this.attackPowerBuilder = new AttackPowerBuilder();
            this.defenseRateBuilder = new DefenseRateBuilder();
            this.damageBuilder = new DamageBuilder();
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
            var attackPower = this.attackPowerBuilder.BuildPower();

            var defenseRate = this.defenseRateBuilder.Build();

            attackPower.NotifyAttackPower(this.damageBuilder);
            defenseRate.NotifyDefenseRate(this.damageBuilder);
            return this.damageBuilder.Build();
        }
    }
}
