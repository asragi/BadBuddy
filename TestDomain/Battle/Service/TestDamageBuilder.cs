using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects;
using BuddyDomain.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestDamageBuilder
    {
        [TestMethod]
        public void Build()
        {
            int damageHolder = 0;

            // Create Mock
            var damageListenerMock = new Mock<IDamageListener>();
            var random = new Mock<IRandom>();

            // Mock Implementation
            random.Setup(r => r.Random()).Returns(0.5f);
            damageListenerMock.Setup(l => l.ListenDamage(It.IsAny<int>()))
                .Callback<int>(d => damageHolder = d);

            // Damage Calculation
            var damageBuilder = new DamageBuilder();
            damageBuilder.ListenAttackPower(100);
            damageBuilder.ListenDefenseRate(0.7f);
            var damage = damageBuilder.Build(random.Object);
            damage.NotifyDamage(damageListenerMock.Object);
            Assert.AreEqual(35, damageHolder);
        }
    }
}
