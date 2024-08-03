using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class CoefficientProfileShiftPinion : IGearParameter
{

    public string Name { get; set; } = "CoefficientProfileShiftPinion";
    public string Description { get; set; } = "CoefficientProfileShiftPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.CoefficientOfProfileShiftPinion;
    public string LatexFormula { get; set; } = @"";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}