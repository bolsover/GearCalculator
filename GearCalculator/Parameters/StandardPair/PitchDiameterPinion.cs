using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class PitchDiameterPinion : IGearParameter
{

    public string Name { get; set; } = "PitchDiameterPinion";
    public string Description { get; set; } = "PitchDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "d";
    public string LatexFormula { get; set; } = @"z_{1}m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teeth);

        var z = teeth.Value;

        var m = module.Value;

        return z * m;
    }
}