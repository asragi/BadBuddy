using BuddyDomain.ValueObjects.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;

namespace BuddyDomain.Entities.Battle
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
            MaxHealthPoint maxHp,
            HealthPoint hp,
            Attack attack,
            Speed speed,
            Magic magic)
        {
            this.ActorId = actorId;
            this.maxHp = maxHp;
            this.hp = hp;
            this.attack = attack;
            this.speed = speed;
            this.magic = magic;
        }

        public ActorId ActorId { get; }

        public bool Alive => this.hp.Alive;

        public void Damaged(HealthPoint val)
            => this.hp = this.hp.Reduce(val);

        public void Recover(HealthPoint inc)
            => this.hp = this.hp.Recover(inc, this.maxHp);
    }
}
