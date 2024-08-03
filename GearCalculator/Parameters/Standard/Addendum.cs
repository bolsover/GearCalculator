using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Addendum : IGearParameter
{
    public string Name { get; set; } = "Addendum";
    public string Description { get; set; } = "Addendum";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.Addendum;
    public string LatexFormula { get; set; } = LatexFormulae.Addendum;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        if (dataDictionary.TryGetValue(GearParameterName.Module, out var module)) return module.Value;

        throw new MissingParameterException("Parameter Addendum is missing from dictionary");
    }
}