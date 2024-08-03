
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class ProfileShiftedExtIntSpurgearPairTests
{
    private readonly ConsoleIO _io = new();
    private static readonly ProfileShiftedExtIntSpurGearPair Gear = new();
    

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary .RetrieveByName(GearParameterName.Module);
        module.Value = 3d;
           
        var teethPinion = Gear.DataDictionary .RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 16;
        var teethWheel = Gear.DataDictionary .RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 24;
        var pressureAngle = Gear.DataDictionary .RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
        var workingCentreDistance = Gear.DataDictionary .RetrieveByName(GearParameterName.WorkingCentreDistance);
        workingCentreDistance.Value = 13.1683d;
        var coefficientProfileShiftPinion =
            Gear.DataDictionary .RetrieveByName(GearParameterName.CoefficientProfileShiftPinion);
        coefficientProfileShiftPinion.Value = 0.0d;
        var coefficientProfileShiftWheel =
            Gear.DataDictionary .RetrieveByName(GearParameterName.CoefficientProfileShiftWheel);
        coefficientProfileShiftWheel.Value = 0.50d;
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
    public void TestDifferenceCoefficientProfileShift()
    {
        Assert.That(0.500d, Is.EqualTo(RetrieveGearValue(GearParameterName.PseiDifferenceCoefficientProfileShift)).Within(0.0001d));
    }

    // [Test]
    // public void TestStandardCentreDistance()
    // {
    //     Assert.AreEqual(54.0d, RetrieveGearValue(GearParameterName.StandardCentreDistance), 0.0001d);
    // }
    //
    // [Test]
    // public void TestInvoluteFunction()
    // {
    //     Assert.AreEqual(0.014904d, RetrieveGearValue(GearParameterName.InvoluteFunction), 0.0001d);
    // }
    //
    // [Test]
    // public void TestWorkingInvoluteFunction()
    // {
    //     Assert.AreEqual(0.034317d, RetrieveGearValue(GearParameterName.WorkingInvoluteFunction), 0.0001d);
    // }
    //
    // [Test]
    // public void TestWorkingPressureAngle()
    // {
    //     Assert.AreEqual(26.08883d, RetrieveGearValue(GearParameterName.WorkingPressureAngle), 0.0001d);
    // }
    //
    // [Test]
    // public void TestCentreDistanceIncrementFactor()
    // {
    //     Assert.AreEqual(0.83333d, RetrieveGearValue(GearParameterName.PseCentreDistanceIncrementFactor), 0.0001d);
    // }
    
    
}