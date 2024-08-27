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
        Assert.That(0.9600d, Is.EqualTo(Gear.SumCoefficientProfileShift.Value).Within(0.0001d));
    }

    [Test]
    public void TestStandardCentreDistance()
    {
        Assert.That(54.0d, Is.EqualTo(Gear.StandardCentreDistance.Value).Within(0.0001d));
    }

    [Test]
    public void TestInvoluteFunction()
    {
        Assert.That(0.014904d, Is.EqualTo(Gear.InvoluteFunction.Value).Within(0.0001d));
    }

    [Test]
    public void TestWorkingInvoluteFunction()
    {
        Assert.That(0.034317d, Is.EqualTo(Gear.WorkingInvoluteFunction.Value).Within(0.0001d));
    }

    [Test]
    public void TestWorkingPressureAngle()
    {
        Assert.That(26.08883d, Is.EqualTo(Gear.WorkingPressureAngle.Value).Within(0.0001d));
    }

    [Test]
    public void TestCentreDistanceIncrementFactor()
    {
        Assert.That(0.83333d, Is.EqualTo(Gear.PseCentreDistanceIncrementFactor.Value).Within(0.0001d));
    }


    [Test]
    public void TestPseAddendumPinion()
    {
        Assert.That(4.41999, Is.EqualTo(Gear.PseAddendumPinion.Value).Within(0.0001d));
    }


    [Test]
    public void TestPseAddendumWheel()
    {
        Assert.That(3.6999, Is.EqualTo(Gear.PseAddendumWheel.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseDedendumPinion()
    {
        Assert.That(1.9500d, Is.EqualTo(Gear.PseDedendumPinion.Value).Within(0.0001d));
    }


    [Test]
    public void TestPseDedendumWheel()
    {
        Assert.That(2.6700d, Is.EqualTo(Gear.PseDedendumWheel.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseWholeDepth()
    {
        Assert.That(6.3699d, Is.EqualTo(Gear.PseWholeDepth.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseOutsideDiameterPinion()
    {
        Assert.That(44.8399d, Is.EqualTo(Gear.PseOutsideDiameterPinion.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseOutsideDiameterWheel()
    {
        Assert.That(79.3999d, Is.EqualTo(Gear.PseOutsideDiameterWheel.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseRootDiameterPinion()
    {
        Assert.That(32.0999d, Is.EqualTo(Gear.PseRootDiameterPinion.Value).Within(0.0001d));
    }


    [Test]
    public void TestPseRootDiameterWheel()
    {
        Assert.That(66.65999d, Is.EqualTo(Gear.PseRootDiameterWheel.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseTotalContactRatio()
    {
        Assert.That(1.20211d, Is.EqualTo(Gear.PseTotalContactRatio.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseWorkingPitchDiameterPinion()
    {
        Assert.That(37.6666d, Is.EqualTo(Gear.PseWorkingPitchDiameterPinion.Value).Within(0.0001d));
    }

    [Test]
    public void TestPseWorkingPitchDiameterWheel()
    {
        Assert.That(75.3333d, Is.EqualTo(Gear.PseWorkingPitchDiameterWheel.Value).Within(0.0001d));
    }

    [Test]
    public void TestBaseDiameterPinion()
    {
        Assert.That(33.82893d, Is.EqualTo(Gear.BaseDiameterPinion.Value).Within(0.0001d));
    }


    [Test]
    public void TestBaseDiameterWheel()
    {
        Assert.That(67.6578d, Is.EqualTo(Gear.BaseDiameterWheel.Value).Within(0.0001d));
    }
}