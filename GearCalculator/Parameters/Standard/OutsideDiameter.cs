using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class OutsideDiameter : IGearParameter
{

    public string Name { get; set; } = "OutsideDiameter";
    public string Description { get; set; } = "OutsideDiameter";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.OutsideDiameter; //@"d_{a}";
    public string LatexFormula { get; set; } = LatexFormulae.OutsideDiameter;//@"d+2m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.Teeth, out var teeth);


        var z = teeth.Value;
        var m = module.Value;


        return z * m + 2 * m;
    }
}