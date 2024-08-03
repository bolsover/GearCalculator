using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class WholeDepth : IGearParameter
{
    public string Name { get; set; } = "WholeDepth";
    public string Description { get; set; } = "WholeDepth";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"h";
    public string LatexFormula { get; set; } = @"\left[2.25 + y -\left(x_{1} + x_{2}\right)\right]m";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}