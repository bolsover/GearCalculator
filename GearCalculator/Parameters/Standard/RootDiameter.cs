using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class RootDiameter : IGearParameter
{

    public string Name { get; set; } = "RootDiameter";
    public string Description { get; set; } = "RootDiameter";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"d_{f}";
    public string LatexFormula { get; set; } = @"d-2.5m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.Teeth, out var teeth);


        var z = teeth.Value;
        var m = module.Value;


        return z * m - 2.5 * m;
    }
}