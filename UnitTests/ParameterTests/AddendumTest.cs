using Bolsover.GearCalculator;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests
{
    [TestFixture]
    public class AddendumTest
    {
        private readonly ConsoleIO _io = new();
        private static readonly InvoluteSpurGear Gear = new();
      

        [SetUp]
        public void SetUp()
        {
            var module = Gear.DataDictionary.RetrieveByName(GearParameterName.Module);
            module.Value = 5d;
        }

        [TearDown]
        public void TearDown()
        {
        }


        [Test]
        public void TestAddendum1()
        {
            var addendum = Gear.DataDictionary.RetrieveByName(GearParameterName.Addendum);
            var v = addendum.Calculate(Gear.DataDictionary);

            Assert.That(v, Is.EqualTo(5d));
        }

       
    }
}