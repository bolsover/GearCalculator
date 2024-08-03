using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class StandardCentreDistance : IGearParameter
{
    public string Name { get; set; } = "StandardCentreDistance";
    public string Description { get; set; } = "StandardCentreDistance";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.StandardCentreDistance;
    public string LatexFormula { get; set; } = @"\frac{\left( z_{1} + z_{2} \right) m}{2}";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;

        return (z1 + z2) * m / 2;
    }
}