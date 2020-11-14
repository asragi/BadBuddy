using BuddyDomain.ValueObjects.Battle;

namespace BuddyDomain.Entities.Battle
{
    public class Actor
    {
        private MaxHealthPoint maxHp;
        private HealthPoint hp;

        public Actor(MaxHealthPoint maxHp, HealthPoint hp)
        {
            this.maxHp = maxHp;
            this.hp = hp;
        }

        public bool Alive => this.hp.Alive;

        public void Damaged(HealthPoint val)
            => this.hp = this.hp.Reduce(val);

        public void Recover(HealthPoint inc)
            => this.hp = this.hp.Recover(inc, this.maxHp);
    }
}
