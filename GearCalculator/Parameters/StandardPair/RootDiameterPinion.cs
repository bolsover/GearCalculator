using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterPinion : IGearParameter
{
    public string Name { get; set; } = "RootDiameterPinion";
    public string Description { get; set; } = "RootDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"d_{f1}";
    public string LatexFormula { get; set; } = @"d{1}-2.5m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);


        var z1 = teethPinion.Value;
        var m = module.Value;


        return z1 * m - 2.5 * m;
    }
}