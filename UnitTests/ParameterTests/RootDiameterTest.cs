using Bolsover.GearCalculator;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests
{
    [TestFixture]
    public class RootDiameterTest
    {
        private readonly ConsoleIO _io = new();
        private static readonly InvoluteSpurGearPair Gear = new();
        private readonly GearDataDictionary _gearDataDictionary = new GearDataDictionary(Gear.Parameters);

        [SetUp]
        public void SetUp()
        {
            var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
            module.Value = 2.5d;
          
            var teethPinion = _gearDataDictionary.RetrieveByName(GearParameterName.TeethPinion);
            teethPinion.Value = 18;
            var teethWheel = _gearDataDictionary.RetrieveByName(GearParameterName.TeethWheel);
            teethWheel.Value = 25;
            var pressureAngle = _gearDataDictionary.RetrieveByName(GearParameterName.PressureAngle);
            pressureAngle.Value = 20;
        }

        [TearDown]
        public void TearDown()
        {
        }

     
        
        [Test]
        public void RootDiameterPinion()
        {
            var rootDiameterPinion = _gearDataDictionary.RetrieveByName(GearParameterName.RootDiameterPinion);
            var expectedValue = 38.75d;
            var v = rootDiameterPinion.Calculate(_gearDataDictionary);

            Assert.That(expectedValue, Is.EqualTo(v).Within(0.1)); 
        }
        
        [Test]
        public void RootDiameterWheel()
        {
            var rootDiameterWheel = _gearDataDictionary.RetrieveByName(GearParameterName.RootDiameterWheel);
            var expectedValue = 56.25d;
            var v = rootDiameterWheel.Calculate(_gearDataDictionary);

            Assert.That(expectedValue, Is.EqualTo(v).Within(0.1)); 
        }
    }
}