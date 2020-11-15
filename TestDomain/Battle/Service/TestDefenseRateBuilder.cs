using BuddyDomain.Battle.Services;
using BuddyDomain.Battle.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestDomain.Battle.Service
{
    [TestClass]
    public class TestDefenseRateBuilder
    {
        [TestMethod]
        public void Build()
        {
            var defenseRateBuilder = new DefenseRateBuilder();
            defenseRateBuilder.Build();
        }
    }
}
