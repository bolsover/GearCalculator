using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterWheel : IGearParameter
{
    public string Name { get; set; } = "PseRootDiameterWheel";
    public string Description { get; set; } = "PseRootDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.RootDiameterWheel;
    public string LatexFormula { get; set; } = @"d_{a2}-2h";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftPinion,
            out var coefficientProfileShiftPinion);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftWheel,
            out var coefficientProfileShiftWheel);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x1 = coefficientProfileShiftPinion.Value;
        var x2 = coefficientProfileShiftWheel.Value;

        var y = ax / m - (z1 + z2) / 2;

        var h = (2.25 + y - (x1 + x2)) * m;
        var ha2 = (1 + y - x1) * m;
        var d2 = z2 * m;
        var da2 = d2 + 2 * ha2;
        return da2 - 2 * h;
    }
}