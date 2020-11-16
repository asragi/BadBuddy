using BuddyDomain.Battle.ValueObjects.Skill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDomain.Battle.ValueObjects.Skill
{
    [TestClass]
    public class TestPriority
    {
        [TestMethod]
        public void CheckCompare()
        {
            var priorityZero = new Priority(0);
            var samePriorityZero = new Priority(0);
            var priorityOne = new Priority(1);

            Assert.IsTrue(priorityOne > priorityZero);
            Assert.IsFalse(priorityZero > priorityOne);
            Assert.IsFalse(priorityZero > samePriorityZero);

            Assert.IsFalse(priorityOne < priorityZero);
            Assert.IsTrue(priorityZero < priorityOne);
            Assert.IsFalse(priorityZero < samePriorityZero);

            Assert.IsTrue(priorityZero == samePriorityZero);
            Assert.IsFalse(priorityOne == priorityZero);

            Assert.IsTrue(priorityZero != priorityOne);
            Assert.IsFalse(priorityZero != samePriorityZero);
        }
    }
}
