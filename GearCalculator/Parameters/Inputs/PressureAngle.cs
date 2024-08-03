using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class PressureAngle : IGearParameter
{
    public string Name { get; set; } = "PressureAngle";
    public string Description { get; set; } = "PressureAngle";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"\alpha";
    public string LatexFormula { get; set; } = "";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}