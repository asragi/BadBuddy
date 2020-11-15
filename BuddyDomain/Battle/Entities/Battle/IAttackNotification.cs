using BuddyDomain.Battle.ValueObjects.Actor;

namespace BuddyDomain.Battle.Entities.Battle
{
    public interface IAttackNotification
    {
        void AttackValue(Attack attack);
    }
}
