using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests;

[TestFixture]
public class DedendumTest
{
    private static readonly InvoluteSpurGear Gear = new();
    private readonly GearDataDictionary _gearDataDictionary = new(Gear.Parameters);

    [SetUp]
    public void SetUp()
    {
        var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 2.5d;
        var teeth = _gearDataDictionary.RetrieveByName(GearParameterName.Teeth);
        teeth.Value = 18;
        // var teethPinion = _gearDataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        // teethPinion.Value = 18;
        // var teethWheel = _gearDataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        // teethWheel.Value = 25;
        var pressureAngle = _gearDataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
    }

    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void TestDedendum()
    {
        

        var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 5d;
        var addendum = _gearDataDictionary.RetrieveByName(GearParameterName.Dedendum);
        const double expectedValue = 6.25d;
        var v = addendum.Calculate(_gearDataDictionary);

        Assert.That(expectedValue, Is.EqualTo(v));
    }
}