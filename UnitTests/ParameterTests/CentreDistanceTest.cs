﻿using Bolsover.GearCalculator;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.ParameterTests
{
    [TestFixture]
public class CentreDistanceTest{
    private readonly ConsoleIO _io = new();
    private static readonly InvoluteSpurGearPair Gear = new();
    private readonly GearDataDictionary _gearDataDictionary = new GearDataDictionary(Gear.Parameters);

    [SetUp]
    public void SetUp()
    {
        var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 2.5d;
        // var teeth = _gearDataDictionary.RetrieveByName(GearParameterName.Teeth);
        // teeth.Value = 18;
        var teethPinion = _gearDataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 18;
        var teethWheel = _gearDataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 25;
        var pressureAngle = _gearDataDictionary.RetrieveByName(GearParameterName.PressureAngle);
        pressureAngle.Value = 20;
    }

    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void CentreDistance1()
    {
       

        var module = _gearDataDictionary.RetrieveByName(GearParameterName.Module);
        module.Value = 2.5d;
        var teethPinion = _gearDataDictionary.RetrieveByName(GearParameterName.TeethPinion);
        teethPinion.Value = 18;
        var teethWheel = _gearDataDictionary.RetrieveByName(GearParameterName.TeethWheel);
        teethWheel.Value = 25;
        var centreDistance = _gearDataDictionary.RetrieveByName(GearParameterName.StandardCentreDistance);
        var expectedValue = 53.75d;
        var v = centreDistance.Calculate(_gearDataDictionary);

        Assert.That(expectedValue, Is.EqualTo(v));
    }
}
}