using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class InvoluteSpurGearTests
{
    [SetUp]
    public void SetUp()
    {
        Gear.Module.Value = 2.5d;
        Gear.Teeth.Value = 18;
        Gear.PressureAngle.Value = 20;
        Gear.Calculate();
    }

    [TearDown]
    public void TearDown()
    {
    }

    private static readonly InvoluteSpurGear Gear = new();


    [Test]
    public void TestPitchDiameter()
    {
        Assert.That(Gear.PitchDiameter.Value, Is.EqualTo(45d));
    }

    [Test]
    public void TestBaseDiameter()
    {
        Assert.That(Gear.BaseDiameter.Value, Is.EqualTo(42.286d).Within(0.1d));
    }

    [Test]
    public void TestAddendum()
    {
        Assert.That(Gear.Addendum.Value, Is.EqualTo(2.5d));
    }

    [Test]
    public void TestDedendum()
    {
        Assert.That(Gear.Dedendum.Value, Is.EqualTo(3.125d));
    }

    [Test]
    public void TestOutsideDiameter()
    {
        Assert.That(Gear.OutsideDiameter.Value, Is.EqualTo(50.0d));
    }

    [Test]
    public void TestRootDiameter()
    {
        Assert.That(Gear.RootDiameter.Value, Is.EqualTo(38.75d));
    }
}