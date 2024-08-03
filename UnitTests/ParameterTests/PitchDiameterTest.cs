using Bolsover.GearCalculator;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests
{
    [TestFixture]
    public class PitchDiameterTest
    {
        private readonly ConsoleIO _io = new();
        private static readonly InvoluteSpurGear Gear = new();
        private readonly GearDataDictionary _gearDataDictionary = new GearDataDictionary(Gear.Parameters);

        [SetUp]
        public void SetUp()
        {
            var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
            module.Value = 2.5d;
            var teeth = _gearDataDictionary.RetrieveByName(GearParameterName.Teeth);
            teeth.Value = 18;
           
            var pressureAngle = _gearDataDictionary.RetrieveByName(GearParameterName.PressureAngle);
            pressureAngle.Value = 20;
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void PitchDiameter()
        {
            var pitchDiameter = _gearDataDictionary.RetrieveByName(GearParameterName.PitchDiameter);
            var expectedValue = 45d;
            var v = pitchDiameter.Calculate(_gearDataDictionary);

            Assert.That(expectedValue, Is.EqualTo(v));
        }
        
     
    }
}