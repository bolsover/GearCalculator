using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterWheel : IGearParameter
{
    public string Name { get; set; } = "RootDiameterWheel";
    public string Description { get; set; } = "RootDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"d_{f2}";
    public string LatexFormula { get; set; } = @"d{2}-2.5m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);


        var z2 = teethWheel.Value;
        var m = module.Value;


        return z2 * m - 2.5 * m;
    }
}