using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class WorkingInvoluteFunction : IGearParameter
{
    public string Name { get; set; } = "WorkingInvoluteFunction";
    public string Description { get; set; } = "WorkingInvoluteFunction";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"inv\:\alpha_{w}";
    public string LatexFormula { get; set; } = @"tan\alpha_{w} - \alpha_{w}";

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

        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));


        return Math.Tan(alphaW) - alphaW;
    }
}