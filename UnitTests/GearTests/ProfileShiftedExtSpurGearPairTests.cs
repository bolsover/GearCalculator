
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class ProfileShiftedExtSpurGearPairTests
{
    private readonly ConsoleIO _io = new();
    private static readonly ProfileShiftedExtSpurGearPair Gear = new();
    

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary .RetrieveByName(GearParameterName.Module);
        module.Value = 3d;
           
        var teethPinion = Gear.DataDictionary .RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 12;
        var teethWheel = Gear.DataDictionary .RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 24;
        var pressureAngle = Gear.DataDictionary .RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
        var workingCentreDistance = Gear.DataDictionary .RetrieveByName(GearParameterName.WorkingCentreDistance);
        workingCentreDistance.Value = 56.5d;
        var coefficientProfileShiftPinion =
            Gear.DataDictionary .RetrieveByName(GearParameterName.CoefficientProfileShiftPinion);
        coefficientProfileShiftPinion.Value = 0.6d;
        var coefficientProfileShiftWheel =
            Gear.DataDictionary .RetrieveByName(GearParameterName.CoefficientProfileShiftWheel);
        coefficientProfileShiftWheel.Value = 0.36d;
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
    public void TestSumCoefficientProfileShift()
    {
        Assert.That(0.9600d, Is.EqualTo(RetrieveGearValue(GearParameterName.SumCoefficientProfileShift)).Within(0.0001d));
    }

    [Test]
    public void TestStandardCentreDistance()
    {
        Assert.That(54.0d, Is.EqualTo(RetrieveGearValue(GearParameterName.StandardCentreDistance)).Within(0.0001d));
    }

    [Test]
    public void TestInvoluteFunction()
    {
        Assert.That(0.014904d, Is.EqualTo(RetrieveGearValue(GearParameterName.InvoluteFunction)).Within(0.0001d));
    }

    [Test]
    public void TestWorkingInvoluteFunction()
    {
        Assert.That(0.034317d, Is.EqualTo(RetrieveGearValue(GearParameterName.WorkingInvoluteFunction)).Within(0.0001d));
    }

    [Test]
    public void TestWorkingPressureAngle()
    {
        Assert.That(26.08883d, Is.EqualTo(RetrieveGearValue(GearParameterName.WorkingPressureAngle)).Within(0.0001d));
    }

    [Test]
    public void TestCentreDistanceIncrementFactor()
    {
        Assert.That(0.83333d, Is.EqualTo(RetrieveGearValue(GearParameterName.PseCentreDistanceIncrementFactor)).Within(0.0001d));
    }
    
    
}