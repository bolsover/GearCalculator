using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class PitchDiameterWheel : IGearParameter
{

    public string Name { get; set; } = "PitchDiameterWheel";
    public string Description { get; set; } = "PitchDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "d";
    public string LatexFormula { get; set; } = @"z_{2}m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teeth);

        var z = teeth.Value;

        var m = module.Value;

        return z * m;
    }
}