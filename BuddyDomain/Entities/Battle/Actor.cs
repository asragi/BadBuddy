using BuddyDomain.ValueObjects.Battle;

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
            MaxHealthPoint maxHp,
            HealthPoint hp,
            Attack attack,
            Speed speed,
            Magic magic)
        {
            this.maxHp = maxHp;
            this.hp = hp;
            this.attack = attack;
            this.speed = speed;
            this.magic = magic;
        }

        public bool Alive => this.hp.Alive;

        public void Damaged(HealthPoint val)
            => this.hp = this.hp.Reduce(val);

        public void Recover(HealthPoint inc)
            => this.hp = this.hp.Recover(inc, this.maxHp);
    }
}
