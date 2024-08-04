
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests;

[TestFixture]
public class WorkingInvoluteFunctionTest
{
    private static readonly ProfileShiftedExtSpurGearPair Gear = new();
        

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 3d;
           
        var teethPinion = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 12;
        var teethWheel = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 24;
        var pressureAngle = Gear.DataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
        var workingCentreDistance = Gear.DataDictionary.RetrieveByName(GearParameterName.WorkingCentreDistance);
        workingCentreDistance.Value = 56.5d;
        var coefficientProfileShiftPinion =
            Gear.DataDictionary.RetrieveByName(GearParameterName.CoefficientProfileShiftPinion);
        coefficientProfileShiftPinion.Value = 0.6d;
        var coefficientProfileShiftWheel =
            Gear.DataDictionary.RetrieveByName(GearParameterName.CoefficientProfileShiftWheel);
        coefficientProfileShiftWheel.Value = 0.36d;
    }
    
    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void WorkingInvoluteFunction()
    {
        var workingInvoluteFunction =
            Gear.DataDictionary.RetrieveByName(GearParameterName.WorkingInvoluteFunction);
        const double expectedValue = 0.034317d;
        var v = workingInvoluteFunction.Calculate(Gear.DataDictionary);

        Assert.That(expectedValue, Is.EqualTo(v).Within(0.0001)); 
    }
        
       
}