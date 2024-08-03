using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class BaseDiameterWheel : IGearParameter
{

    public string Name { get; set; } = "BaseDiameterWheel";
    public string Description { get; set; } = "BaseDiameterWheel";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.BaseDiameterWheel;
    public string LatexFormula { get; set; } = LatexFormulae.BaseDiameterWheel;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);

        var z2 = teethWheel.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z2 * m * Math.Cos(Radians(a));
    }
}