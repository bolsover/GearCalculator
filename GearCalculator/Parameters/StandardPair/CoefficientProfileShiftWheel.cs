using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class CoefficientProfileShiftWheel : IGearParameter
{
    public string Name { get; set; } = "CoefficientProfileShiftWheel";
    public string Description { get; set; } = "CoefficientProfileShiftWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.CoefficientOfProfileShiftWheel;
    public string LatexFormula { get; set; } = @"";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}