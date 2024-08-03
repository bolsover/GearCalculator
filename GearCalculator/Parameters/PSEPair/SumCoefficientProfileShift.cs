using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class SumCoefficientProfileShift : IGearParameter
{
    public string Name { get; set; } = "SumCoefficientProfileShift";
    public string Description { get; set; } = "SumCoefficientProfileShift";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.SumCoefficientOfProfileShift;

    public string LatexFormula { get; set; } = LatexFormulae.SumCoefficientOfProfileShift;

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

        var y = ax / m - (z1 + z2) / 2;
        var invAlpha = Math.Tan(alpha) - alpha;
        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));
        var invAlphaW = Math.Tan(alphaW) - alphaW;

        return (z1 + z2) * (invAlphaW - invAlpha) / (2 * Math.Tan(alpha));
    }
}