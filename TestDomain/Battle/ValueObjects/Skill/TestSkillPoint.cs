using BuddyDomain.Battle.ValueObjects.Skill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Battle.ValueObjects.Skill
{
    [TestClass]
    public class TestSkillPoint
    {
        [TestMethod]
        public void Consume()
        {
            var skillPoint = new SkillPoint(2);
            Assert.IsTrue(skillPoint.CheckRemain());
            skillPoint = skillPoint.Consume();
            Assert.IsTrue(skillPoint.CheckRemain());
            skillPoint = skillPoint.Consume();
            Assert.IsFalse(skillPoint.CheckRemain());
        }

        [TestMethod]
        public void CanCreateZeroPoint()
        {
            var skillPoint = new SkillPoint(0);
            Assert.IsFalse(skillPoint.CheckRemain());
        }
    }
}
