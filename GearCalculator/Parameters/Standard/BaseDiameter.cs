using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class BaseDiameter : IGearParameter
{

    public string Name { get; set; } = "BaseDiameter";
    public string Description { get; set; } = "BaseDiameter";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.BaseDiameter;
    public string LatexFormula { get; set; } = LatexFormulae.BaseDiameter;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.Teeth, out var teeth);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);

        var z = teeth.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z * m * Math.Cos(Radians(a));
    }
}