using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class TeethPinion : IGearParameter
{
    public string Name { get; set; } = "TeethPinion";
    public string Description { get; set; } = "Teeth Pinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "z_{1}";
    public string LatexFormula { get; set; } = "";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}