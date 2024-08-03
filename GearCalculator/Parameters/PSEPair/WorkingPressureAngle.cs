﻿using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class WorkingPressureAngle : IGearParameter
{
    public string Name { get; set; } = "WorkingPressureAngle";
    public string Description { get; set; } = "WorkingPressureAngle";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"alpha_{w}";

    public string LatexFormula { get; set; } =
        @" cos^{-1}\left[\frac{\left(z_{1}+z_{2}\right)cos\:\alpha}{2y+z_{1}+z_{2}}\right]";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);
        var alpha = Radians(pressureAngle.Value);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;

        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2);
        return Degrees(Math.Acos(cosAlphaW));
    }
}