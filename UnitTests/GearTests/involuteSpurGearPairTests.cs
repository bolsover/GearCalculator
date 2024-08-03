
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class InvoluteSpurGearPairTests
{
    private readonly ConsoleIO _io = new();
    private static readonly InvoluteSpurGearPair Gear = new();
   

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 2.5d;
        var teethPinion = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 18;
        var teethWheel = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 25;
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
    public void TestPitchDiameterPinion()
    {
        Assert.That(45.0d, Is.EqualTo(RetrieveGearValue(GearParameterName.PitchDiameterPinion)));
    }

    [Test]
    public void TestPitchDiameterWheel()
    {
        Assert.That(62.5d, Is.EqualTo(RetrieveGearValue(GearParameterName.PitchDiameterWheel)));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(42.286d, Is.EqualTo(RetrieveGearValue(GearParameterName.BaseDiameterPinion)).Within(0.1d));
    }

    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(58.731d, Is.EqualTo(RetrieveGearValue(GearParameterName.BaseDiameterWheel)).Within(0.1d));
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
    public void TestOutsideDiameterPinion()
    {
        Assert.That(50.0d, Is.EqualTo(RetrieveGearValue(GearParameterName.OutsideDiameterPinion)));
    }

    [Test]
    public void TestOutsideDiameterWheel()
    {
        Assert.That(67.5d, Is.EqualTo(RetrieveGearValue(GearParameterName.OutsideDiameterWheel)));
    }

    [Test]
    public void TestRootDiameterPinion()
    {
        Assert.That(38.75d, Is.EqualTo(RetrieveGearValue(GearParameterName.RootDiameterPinion)));
    }

    [Test]
    public void TestRootDiameterWheel()
    {
        Assert.That(56.25d, Is.EqualTo(RetrieveGearValue(GearParameterName.RootDiameterWheel)));
    }
    [Test]
    public void TestCentreDistance()
    {
        Assert.That(53.75d, Is.EqualTo(RetrieveGearValue(GearParameterName.StandardCentreDistance)));
    }
}