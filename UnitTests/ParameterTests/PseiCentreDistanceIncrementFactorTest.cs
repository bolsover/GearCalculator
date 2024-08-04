
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests;

[TestFixture]
public class PseiCentreDistanceIncrementFactorTest
{
    private static readonly ProfileShiftedExtIntSpurGearPair Gear = new();
       

    [SetUp]
    public void SetUp()
    {
        var module = Gear.DataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 3d;
           
        var teethPinion = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 16;
        var teethWheel = Gear.DataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 24;
        var pressureAngle = Gear.DataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
        var workingCentreDistance = Gear.DataDictionary.RetrieveByName(GearParameterName.WorkingCentreDistance);
        workingCentreDistance.Value = 13.1683;
        var coefficientProfileShiftPinion =
            Gear.DataDictionary.RetrieveByName(GearParameterName.CoefficientProfileShiftPinion);
        coefficientProfileShiftPinion.Value = 0.0d;
        var coefficientProfileShiftWheel =
            Gear.DataDictionary.RetrieveByName(GearParameterName.CoefficientProfileShiftWheel);
        coefficientProfileShiftWheel.Value = 0.5d;
    }
    
    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void ProfileShiftExtIntCentreDistanceIncrementFactor()
    {
        var centreDistanceIncrementFactor =
            Gear.DataDictionary.RetrieveByName(GearParameterName.PseiCentreDistanceIncrementFactor);
        const double expectedValue = 0.38943;
        var v = centreDistanceIncrementFactor.Calculate(Gear.DataDictionary);

        Assert.That(expectedValue, Is.EqualTo(v).Within(0.1)); 
    }
        
       
}