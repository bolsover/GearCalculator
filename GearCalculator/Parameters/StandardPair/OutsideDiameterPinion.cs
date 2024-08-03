using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterPinion : IGearParameter
{

    public string Name { get; set; } = "OutsideDiameterPinion";
    public string Description { get; set; } = "OutsideDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.OutsideDiameterPinion;
    public string LatexFormula { get; set; } = LatexFormulae.OutsideDiameterPinion;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);


        var z1 = teethPinion.Value;
        var m = module.Value;


        return z1 * m + 2 * m;
    }
}