using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumWheel : IGearParameter
{
    public string Name { get; set; } = "PseAddendumWheel";
    public string Description { get; set; } = "PseAddendumWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.AddendumWheel;
    public string LatexFormula { get; set; } = LatexFormulae.PseAddendumWheel; // @"\left(1+y-x_{1}\right)m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftPinion,
            out var coefficientProfileShiftPinion);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x1 = coefficientProfileShiftPinion.Value;

        var y = ax / m - (z1 + z2) / 2;

        return (1 + y - x1) * m;
    }
}