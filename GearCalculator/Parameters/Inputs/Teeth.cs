using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class Teeth : IGearParameter
{
    public string Name { get; set; } = "Teeth";
    public string Description { get; set; } = "Teeth";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "z";
    public string LatexFormula { get; set; } = "";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}