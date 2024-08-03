using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterPinion : IGearParameter
{
    public string Name { get; set; } = "PseOutsideDiameterWheel";
    public string Description { get; set; } = "PseOutsideDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.OutsideDiameterPinion;
    public string LatexFormula { get; set; } = @"d_{1}-2h_{a1}";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftWheel,
            out var coefficientProfileShiftWheel);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x2 = coefficientProfileShiftWheel.Value;

        var y = ax / m - (z1 + z2) / 2;

        var ha1 = (1 + y - x2) * m;

        var d1 = z1 * m;
        return d1 + 2 * ha1;
    }
}