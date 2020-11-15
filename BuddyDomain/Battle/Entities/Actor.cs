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
            ActorId = actorId;
            ActorType = actorType;
            this.maxHp = maxHp;
            this.hp = hp;
            this.attack = attack;
            this.speed = speed;
            this.magic = magic;
        }

        public ActorId ActorId { get; }

        public ActorType ActorType { get; }

        public bool Alive => hp.Alive;

        public void Damaged(HealthPoint val)
            => hp = hp.Reduce(val);

        public void Recover(HealthPoint inc)
            => hp = hp.Recover(inc, maxHp);

        public void NotifyAttackFactor(IAttackNotification notification)
        {
            notification.AttackValue(attack);
        }

        public void NotifyMagicFactor(IMagicNotification notification)
        {
            notification.MagicValue(magic);
        }

        public void NotifySpeedFactor(ISpeedNotification notification)
        {
            notification.SpeedValue(speed);
        }
    }
}
