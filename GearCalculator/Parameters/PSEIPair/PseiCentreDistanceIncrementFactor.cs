
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiCentreDistanceIncrementFactor : IGearParameter
{
    public string Name { get; set; } = "PseiCentreDistanceIncrementFactor";
    public string Description { get; set; } = "PseiCentreDistanceIncrementFactor";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.CentreDistanceIncrementFactor;
    public string LatexFormula { get; set; } = LatexFormulae.ProfileShiftExtIntCentreDistanceIncrementFactor;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;

        return ax / m - (z2 - z1) / 2;
    }
}