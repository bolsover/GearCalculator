using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class PitchDiameter : IGearParameter
{

    public string Name { get; set; } = "PitchDiameter";
    public string Description { get; set; } = "PitchDiameter";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "d";
    public string LatexFormula { get; set; } = @"zm";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.Teeth, out var teeth);

        var z = teeth.Value;

        var m = module.Value;

        return z * m;
    }
}