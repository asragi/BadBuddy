using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestAttackPowerBuilderInner
    {
        [TestMethod]
        public void Build()
        {
            var listenerMock = new Mock<IDamageListener>();
            listenerMock.Setup(l => l.ListenDamage(It.IsAny<int>()))
                .Callback<int>(p => Assert.AreEqual(5000, p));

            var builder = new AttackPowerBuilderInner();
            builder.ListenAttackValue(50);
            builder.ListenForceValue(100);
            var attackPower = builder.Build();
            attackPower.NotifyDamage(listenerMock.Object);
        }
    }
}
