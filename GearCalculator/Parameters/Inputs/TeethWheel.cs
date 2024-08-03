using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class TeethWheel : IGearParameter
{
    public string Name { get; set; } = "TeethWheel";
    public string Description { get; set; } = "Teeth Wheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "z_{2}";
    public string LatexFormula { get; set; } = "";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}