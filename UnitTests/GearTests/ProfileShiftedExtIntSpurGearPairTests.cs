using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class ProfileShiftedExtIntSpurGearPairTests
{
    [SetUp]
    public void SetUp()
    {
        Gear.Module.Value = 3d;
        Gear.TeethPinion.Value = 16;
        Gear.TeethWheel.Value = 24;
        Gear.PressureAngle.Value = 20;
        Gear.WorkingCentreDistance.Value = 13.1683d;
        Gear.CoefficientProfileShiftPinion.Value = 0.0d;
        Gear.CoefficientProfileShiftWheel.Value = 0.50d;
        Gear.Calculate();
    }

    [TearDown]
    public void TearDown()
    {
    }

    private static readonly ProfileShiftedExtIntSpurGearPair Gear = new();

    [Test]
    public void TestPseiWorkingPressureAngle()
    {
        Assert.That(Gear.WorkingPressureAngle.Value, Is.EqualTo(31.09385d).Within(0.0001d));
    }

    [Test]
    public void TestPseiInvoluteFunction()
    {
        Assert.That(Gear.InvoluteFunction.Value, Is.EqualTo(0.06040d).Within(0.0001d));
    }

    [Test]
    public void TestDifferenceCoefficientProfileShift()
    {
        Assert.That(Gear.DifferenceCoefficientProfileShift.Value, Is.EqualTo(0.5000d).Within(0.0001d));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(Gear.BaseDiameterPinion.Value, Is.EqualTo(45.1052d).Within(0.0001d));
    }

    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(Gear.BaseDiameterWheel.Value, Is.EqualTo(67.6578d).Within(0.0001d));
    }

    [Test]
    public void TestPseiStandardCentreDistance()
    {
        Assert.That(Gear.StandardCentreDistance.Value, Is.EqualTo(12.000d).Within(0.0001d));
    }

    [Test]
    public void TestPseiCentreDistanceIncrementFactor()
    {
        Assert.That(Gear.CentreDistanceIncrementFactor.Value, Is.EqualTo(0.3894d).Within(0.0001d));
    }

    [Test]
    public void TestInvoluteFunction()
    {
        Assert.That(Gear.InvoluteFunction.Value, Is.EqualTo(0.06040d).Within(0.0001d));
    }

    [Test]
    public void TestPitchDiameterPinion()
    {
        Assert.That(Gear.PitchDiameterPinion.Value, Is.EqualTo(48.000d).Within(0.0001d));
    }


    [Test]
    public void TestPitchDiameterWheel()
    {
        Assert.That(Gear.PitchDiameterWheel.Value, Is.EqualTo(72.000d).Within(0.0001d));
    }

    [Test]
    public void TestPseiAddendumPinion()
    {
        Assert.That(Gear.AddendumPinion.Value, Is.EqualTo(3.000d).Within(0.0001d));
    }


    [Test]
    public void TestPseAddendumWheel()
    {
        Assert.That(Gear.AddendumWheel.Value, Is.EqualTo(1.500d).Within(0.0001d));
    }

    [Test]
    public void TestPseiDedendumPinion()
    {
        Assert.That(Gear.DedendumPinion.Value, Is.EqualTo(3.75d).Within(0.0001d));
    }

    [Test]
    public void TestPseiDedendumWheel()
    {
        Assert.That(Gear.DedendumWheel.Value, Is.EqualTo(5.25d).Within(0.0001d));
    }
}