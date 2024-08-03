using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class Module : IGearParameter
{
    public string Name { get; set; } = "Module";
    public string Description { get; set; } = "Module";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.Module;
    public string LatexFormula { get; set; } = "";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}