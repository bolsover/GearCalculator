using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterWheel : IGearParameter
{

    public string Name { get; set; } = "OutsideDiameterWheel";
    public string Description { get; set; } = "OutsideDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.OutsideDiameterWheel;
    public string LatexFormula { get; set; } = LatexFormulae.OutsideDiameterWheel;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);


        var z2 = teethWheel.Value;
        var m = module.Value;


        return z2 * m + 2 * m;
    }
}