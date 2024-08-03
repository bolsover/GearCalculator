using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterPinion : IGearParameter
{
    public string Name { get; set; } = "PseRootDiameterPinion";
    public string Description { get; set; } = "PseRootDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.RootDiameterPinion;
    public string LatexFormula { get; set; } = @"d_{a1}-2h";

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
        var ha1 = (1 + y - x2) * m;
        var d1 = z1 * m;
        var da1 = d1 + 2 * ha1;
        return da1 - 2 * h;
    }
}