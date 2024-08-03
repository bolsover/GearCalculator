using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterWheel : IGearParameter
{
    public string Name { get; set; } = "PseOutsideDiameterWheel";
    public string Description { get; set; } = "PseOutsideDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.DedendumWheel;
    public string LatexFormula { get; set; } = @"d_{2}-2h_{a2}";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftPinion,
            out var coefficientProfileShiftPinion);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x1 = coefficientProfileShiftPinion.Value;

        var y = ax / m - (z1 + z2) / 2;

        var ha2 = (1 + y - x1) * m;

        var d2 = z2 * m;
        return d2 + 2 * ha2;
    }
}