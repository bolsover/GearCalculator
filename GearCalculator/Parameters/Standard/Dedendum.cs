using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Dedendum : IGearParameter
{
    public string Name { get; set; } = "Dedendum";
    public string Description { get; set; } = "Dedendum";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.Dedendum;
    public string LatexFormula { get; set; } = LatexFormulae.Dedendum;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        if (dataDictionary.TryGetValue(GearParameterName.Module, out var module)) return module.Value * 1.25;

        throw new MissingParameterException("Parameter Module is missing from dictionary");
    }
}