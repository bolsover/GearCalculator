using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.Standard;

public class InvoluteFunction : IGearParameter
{
    public string Name { get; set; } = "InvoluteFunction";
    public string Description { get; set; } = "InvoluteFunction";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.InvoluteFunction; //@"inv\:\alpha";
    public string LatexFormula { get; set; } = LatexFormulae.InvoluteFunction;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);
        var alpha = Radians(pressureAngle.Value);
        return Math.Tan(alpha) - alpha;
    }
}