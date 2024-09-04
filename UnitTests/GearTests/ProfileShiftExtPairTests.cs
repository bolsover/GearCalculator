using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class ProfileShiftExtPairTests
{
    [SetUp]
    public void SetUp()
    {
        Gear.Module.Value = 3d;
        Gear.TeethPinion.Value = 12;
        Gear.TeethWheel.Value = 24;
        Gear.PressureAngle.Value = 20;
        Gear.WorkingCentreDistance.Value = 56.5d;
        Gear.CoefficientProfileShiftPinion.Value = 0.6d;
        Gear.CoefficientProfileShiftWheel.Value = 0.36d;
        Gear.Calculate();
    }

    [TearDown]
    public void TearDown()
    {
    }

    private static readonly ProfileShiftExtPair Gear = new();


    [Test]
    public void TestSumCoefficientProfileShift()
    {
        Assert.That(Gear.SumCoefficientProfileShift.Value, Is.EqualTo(0.9600d).Within(0.0001d));
    }

    [Test]
    public void TestStandardCentreDistance()
    {
        Assert.That(Gear.StandardCentreDistance.Value, Is.EqualTo(54.0d).Within(0.0001d));
    }

    [Test]
    public void TestInvoluteFunction()
    {
        Assert.That(Gear.InvoluteFunction.Value, Is.EqualTo(0.014904d).Within(0.0001d));
    }

    [Test]
    public void TestWorkingInvoluteFunction()
    {
        Assert.That(Gear.WorkingInvoluteFunction.Value , Is.EqualTo(0.034317d).Within(0.0001d));
    }

    [Test]
    public void TestWorkingPressureAngle()
    {
        Assert.That(Gear.WorkingPressureAngle.Value , Is.EqualTo(26.08883d).Within(0.0001d));
    }

    [Test]
    public void TestCentreDistanceIncrementFactor()
    {
        Assert.That(Gear.CentreDistanceIncrementFactor.Value, Is.EqualTo( 0.83333d).Within(0.0001d));
    }


    [Test]
    public void TestPseAddendumPinion()
    {
        Assert.That(Gear.AddendumPinion.Value, Is.EqualTo( 4.41999).Within(0.0001d));
        // Gear.Module.Value = 4d;
        // Gear.Calculate();
        // Assert.That(Gear.AddendumPinion.Value, Is.EqualTo( 4.41999).Within(0.0001d));
    }


    [Test]
    public void TestPseAddendumWheel()
    {
        Assert.That(Gear.AddendumWheel.Value , Is.EqualTo(3.6999).Within(0.0001d));
    }

    [Test]
    public void TestPseDedendumPinion()
    {
        Assert.That(Gear.DedendumPinion.Value , Is.EqualTo(1.9500d).Within(0.0001d));
    }


    [Test]
    public void TestPseDedendumWheel()
    {
        Assert.That(Gear.DedendumWheel.Value , Is.EqualTo(2.6700d).Within(0.0001d));
    }

    [Test]
    public void TestPseWholeDepth()
    {
        Assert.That(Gear.WholeDepth.Value , Is.EqualTo(6.3699d).Within(0.0001d));
    }

    [Test]
    public void TestPseOutsideDiameterPinion()
    {
        Assert.That(Gear.OutsideDiameterPinion.Value , Is.EqualTo(44.8399d).Within(0.0001d));
    }

    [Test]
    public void TestPseOutsideDiameterWheel()
    {
        Assert.That(Gear.OutsideDiameterWheel.Value , Is.EqualTo(79.3999d).Within(0.0001d));
    }

    [Test]
    public void TestPseRootDiameterPinion()
    {
        Assert.That(Gear.RootDiameterPinion.Value, Is.EqualTo( 32.0999d).Within(0.0001d));
    }


    [Test]
    public void TestPseRootDiameterWheel()
    {
        Assert.That(Gear.RootDiameterWheel.Value , Is.EqualTo(66.65999d ).Within(0.0001d));
    }

    [Test]
    public void TestPseTotalContactRatio()
    {
        Assert.That(Gear.TotalContactRatio.Value, Is.EqualTo( 1.20211d).Within(0.0001d));
    }

    [Test]
    public void TestPseWorkingPitchDiameterPinion()
    {
        Assert.That(Gear.WorkingPitchDiameterPinion.Value, Is.EqualTo(37.6666d).Within(0.0001d));
    }

    [Test]
    public void TestPseWorkingPitchDiameterWheel()
    {
        Assert.That(Gear.WorkingPitchDiameterWheel.Value, Is.EqualTo( 75.3333d).Within(0.0001d));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(Gear.BaseDiameterPinion.Value, Is.EqualTo( 33.82893d).Within(0.0001d));
    }


    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(Gear.BaseDiameterWheel.Value, Is.EqualTo( 67.6578d).Within(0.0001d));
    }
}