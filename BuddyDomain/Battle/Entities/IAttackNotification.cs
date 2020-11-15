using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Entities
{
    public interface IAttackNotification
    {
        void AttackValue(Attack attack);
    }
}
