using Bolsover.GearCalculator;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class InvoluteSpurGearTests
{
    private readonly ConsoleIO _io = new();
    private static readonly InvoluteSpurGear Gear = new();
  

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 2.5d;
        var teeth = Gear.DataDictionary.RetrieveByName(GearParameterName.Teeth);
        teeth.Value = 18;
        var pressureAngle = Gear.DataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
    }
    
    [TearDown]
    public void TearDown()
    {
    }

    
    public double RetrieveGearValue(GearParameterName name)
    {
        Gear.Calculate();
        return Gear.DataDictionary.RetrieveByName(name).Value;
    }

    [Test]
    public void TestPitchDiameter()
    {
        Assert.That(45d, Is.EqualTo(RetrieveGearValue(GearParameterName.PitchDiameter)));
    }

    [Test]
    public void TestBaseDiameter()
    {
        Assert.That(42.286d, Is.EqualTo(RetrieveGearValue(GearParameterName.BaseDiameter)).Within(0.1d));
    }

    [Test]
    public void TestAddendum()
    {
        Assert.That(2.5d, Is.EqualTo(RetrieveGearValue(GearParameterName.Addendum)));
    }

    [Test]
    public void TestDedendum()
    {
        Assert.That(3.125d, Is.EqualTo(RetrieveGearValue(GearParameterName.Dedendum)));
    }

    [Test]
    public void TestOutsideDiameter()
    {
        Assert.That(50.0d, Is.EqualTo(RetrieveGearValue(GearParameterName.OutsideDiameter)));
    }

    [Test]
    public void TestRootDiameter()
    {
        Assert.That(38.75d, Is.EqualTo(RetrieveGearValue(GearParameterName.RootDiameter)));
    }
}