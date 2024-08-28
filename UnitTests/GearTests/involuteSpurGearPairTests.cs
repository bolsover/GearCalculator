using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class InvoluteSpurGearPairTests
{
    [SetUp]
    public void SetUp()
    {
        Gear.Module.Value = 2.5d;
        Gear.TeethPinion.Value = 18d;
        Gear.TeethWheel.Value = 25d;
        Gear.PressureAngle.Value = 20d;
        Gear.Calculate();
    }

    [TearDown]
    public void TearDown()
    {
    }

    private static readonly InvoluteSpurGearPair Gear = new();


    [Test]
    public void TestPitchDiameterPinion()
    {
        Assert.That(Gear.PitchDiameterPinion.Value, Is.EqualTo(45.0d));
    }

    [Test]
    public void TestPitchDiameterWheel()
    {
        Assert.That(Gear.PitchDiameterWheel.Value, Is.EqualTo(62.5d));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(Gear.BaseDiameterPinion.Value , Is.EqualTo(42.286d).Within(0.001d));
    }

    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(Gear.BaseDiameterWheel.Value , Is.EqualTo(58.731d).Within(0.001d));
    }

    [Test]
    public void TestAddendum()
    {
        Assert.That(Gear.Addendum.Value, Is.EqualTo(2.5d));
    }

    [Test]
    public void TestDedendum()
    {
        Assert.That(Gear.Dedendum.Value, Is.EqualTo( 3.125d));
    }

    [Test]
    public void TestOutsideDiameterPinion()
    {
        Assert.That(Gear.OutsideDiameterPinion.Value , Is.EqualTo(50.0d));
    }

    [Test]
    public void TestOutsideDiameterWheel()
    {
        Assert.That(Gear.OutsideDiameterWheel.Value, Is.EqualTo( 67.5d));
    }

    [Test]
    public void TestRootDiameterPinion()
    {
        Assert.That(Gear.RootDiameterPinion.Value , Is.EqualTo(38.75d));
    }

    [Test]
    public void TestRootDiameterWheel()
    {
        Assert.That(Gear.RootDiameterWheel.Value, Is.EqualTo(56.25d));
    }

    [Test]
    public void TestStandardCentreDistance()
    {
        Assert.That(Gear.StandardCentreDistance.Value, Is.EqualTo( 53.75d));
    }
}