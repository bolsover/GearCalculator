
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.GearTests;

[TestFixture]
public class ProfileShiftedExtIntSpurGearPairTests
{
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


    private static double RetrieveGearValue(GearParameterName name)
    {
        Gear.Calculate();
        return Gear.DataDictionary.RetrieveByName(name).Value;
    }

    [Test]
    public void TestDifferenceCoefficientProfileShift()
    {
        Assert.That(0.500d, Is.EqualTo(RetrieveGearValue(GearParameterName.PseiDifferenceCoefficientProfileShift)).Within(0.0001d));
    }

   
    
    
}