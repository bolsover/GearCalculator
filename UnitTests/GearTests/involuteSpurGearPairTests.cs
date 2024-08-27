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
        Assert.That(45.0d, Is.EqualTo(Gear.PitchDiameterPinion.Value));
    }

    [Test]
    public void TestPitchDiameterWheel()
    {
        Assert.That(62.5d, Is.EqualTo(Gear.PitchDiameterWheel.Value));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(42.286d, Is.EqualTo(Gear.BaseDiameterPinion.Value).Within(0.001d));
    }

    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(58.731d, Is.EqualTo(Gear.BaseDiameterWheel.Value).Within(0.001d));
    }

    [Test]
    public void TestAddendum()
    {
        Assert.That(2.5d, Is.EqualTo(Gear.Addendum.Value));
    }

    [Test]
    public void TestDedendum()
    {
        Assert.That(3.125d, Is.EqualTo(Gear.Dedendum.Value));
    }

    [Test]
    public void TestOutsideDiameterPinion()
    {
        Assert.That(50.0d, Is.EqualTo(Gear.OutsideDiameterPinion.Value));
    }

    [Test]
    public void TestOutsideDiameterWheel()
    {
        Assert.That(67.5d, Is.EqualTo(Gear.OutsideDiameterWheel.Value));
    }

    [Test]
    public void TestRootDiameterPinion()
    {
        Assert.That(38.75d, Is.EqualTo(Gear.RootDiameterPinion.Value));
    }

    [Test]
    public void TestRootDiameterWheel()
    {
        Assert.That(56.25d, Is.EqualTo(Gear.RootDiameterWheel.Value));
    }

    [Test]
    public void TestStandardCentreDistance()
    {
        Assert.That(53.75d, Is.EqualTo(Gear.StandardCentreDistance.Value));
    }
}