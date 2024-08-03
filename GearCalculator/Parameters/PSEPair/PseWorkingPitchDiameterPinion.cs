using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseWorkingPitchDiameterPinion : IGearParameter
{
    public string Name { get; set; } = "PseWorkingPitchDiameterPinion";
    public string Description { get; set; } = "PseWorkingPitchDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "d_{w1}";
    public string LatexFormula { get; set; } = @"\frac{d_{b1}}{cos\alpha_{w}}";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);
        var alpha = Radians(pressureAngle.Value); // pressure angle radians
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;

        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2); // cosine working pressure angle radians
        var db1 = z1 * m * Math.Cos(alpha);
        return db1 / cosAlphaW;
    }
}