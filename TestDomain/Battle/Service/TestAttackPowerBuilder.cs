using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestAttackPowerBuilder
    {
        [TestMethod]
        public void Build()
        {
            var innerBuilder = new Mock<IAttackPowerBuilderInner>();
            var attackPowerMock = new Damage(5000);
            innerBuilder.Setup(i => i.Build()).Returns(attackPowerMock);

            var builder = new AttackPowerBuilder(innerBuilder.Object);
            var attackPower = builder.Build();

            var mockListener = new Mock<IDamageListener>();
            mockListener.Setup(l => l.ListenDamage(It.IsAny<int>()))
                .Callback<int>(power => Assert.AreEqual(5000, power));
            attackPower.NotifyDamage(mockListener.Object);
        }
    }
}
