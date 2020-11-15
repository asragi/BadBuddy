using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Entities
{
    public class Actor
    {
        private MaxHealthPoint maxHp;
        private HealthPoint hp;
        private Attack attack;
        private Speed speed;
        private Magic magic;

        public Actor(
            ActorId actorId,
            ActorType actorType,
            MaxHealthPoint maxHp,
            HealthPoint hp,
            Attack attack,
            Speed speed,
            Magic magic)
        {
            this.ActorId = actorId;
            this.ActorType = actorType;
            this.maxHp = maxHp;
            this.hp = hp;
            this.attack = attack;
            this.speed = speed;
            this.magic = magic;
        }

        public ActorId ActorId { get; }

        public ActorType ActorType { get; }

        public bool Alive => this.hp.Alive;

        public void Damaged(HealthPoint val)
            => this.hp = this.hp.Reduce(val);

        public void Recover(HealthPoint inc)
            => this.hp = this.hp.Recover(inc, this.maxHp);

        public void NotifyAttackFactor(IAttackNotification notification)
        {
            notification.AttackValue(this.attack);
        }

        public void NotifyMagicFactor(IMagicNotification notification)
        {
            notification.MagicValue(this.magic);
        }

        public void NotifySpeedFactor(ISpeedNotification notification)
        {
            notification.SpeedValue(this.speed);
        }
    }
}
