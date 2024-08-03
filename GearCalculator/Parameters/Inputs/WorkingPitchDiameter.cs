using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class WorkingPitchDiameter : IGearParameter
{
    public string Name { get; set; } = "WorkingPitchDiameter";
    public string Description { get; set; } = "WorkingPitchDiameter";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = @"d_{w}";
    public string LatexFormula { get; set; } = @"\frac{d_{b}}{cos\alpha_{w}} ";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        throw new NotImplementedException();
    }
}