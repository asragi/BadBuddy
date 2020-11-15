using BuddyDomain.Battle.Entities.Battle;
using BuddyDomain.Battle.ValueObjects.Actor;
using BuddyDomain.Battle.ValueObjects.Skill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Battle.Entities
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
