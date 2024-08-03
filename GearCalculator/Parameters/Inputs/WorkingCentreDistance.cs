using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class WorkingCentreDistance : IGearParameter
{
    public string Name { get; set; } = "WorkingCentreDistance";
    public string Description { get; set; } = "WorkingCentreDistance";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.WorkingCentreDistance;
    public string LatexFormula { get; set; } = @"";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}