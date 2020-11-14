using BuddyDomain.Entities.Battle;
using BuddyDomain.ValueObjects.Battle.Actor;
using BuddyDomain.ValueObjects.Battle.Skill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Entities.Battle
{
    [TestClass]
    public class TestSkillRemaining
    {
        [TestMethod]
        public void Consume()
        {
            var skillRemaining = Create();
            Assert.IsTrue(skillRemaining.CheckRemain());
            skillRemaining.Consume();
            Assert.IsTrue(skillRemaining.CheckRemain());
            skillRemaining.Consume();
            Assert.IsFalse(skillRemaining.CheckRemain());
        }

        private static SkillRemaining Create()
        {
            var skillId = new SkillId("TestSkill");
            var actorId = new ActorId("TestActor");
            var skillPoint = new SkillPoint(2);
            return new SkillRemaining(skillId, actorId, skillPoint);
        }
    }
}
