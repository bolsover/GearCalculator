using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests;

[TestFixture]
public class BaseDiameterTest
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
        var pressureAngle = _gearDataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
    }

    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void BaseDiameter()
    {
        var baseDiameter = _gearDataDictionary.RetrieveByName(GearParameterName.BaseDiameter);
        const double expectedValue = 42.286d;
        var v = baseDiameter.Calculate(_gearDataDictionary);

        Assert.That(expectedValue, Is.EqualTo(v).Within(0.1)); 
    }
        
}