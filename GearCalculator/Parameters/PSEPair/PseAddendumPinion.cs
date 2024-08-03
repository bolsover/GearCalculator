using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumPinion : IGearParameter
{
    public string Name { get; set; } = "PSEAddendumPinion";
    public string Description { get; set; } = "PSEAddendumPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.AddendumPinion;
    public string LatexFormula { get; set; } = LatexFormulae.PseAddendumPinion; // @"\left(1+y-x_{2}\right)m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftWheel,
            out var coefficientProfileShiftWheel);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x2 = coefficientProfileShiftWheel.Value;

        var y = ax / m - (z1 + z2) / 2;

        return (1 + y - x2) * m;
    }
}