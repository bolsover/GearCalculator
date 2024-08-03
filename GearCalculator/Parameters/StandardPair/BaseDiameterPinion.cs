using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class BaseDiameterPinion : IGearParameter
{

    public string Name { get; set; } = "BaseDiameterPinion";
    public string Description { get; set; } = "BaseDiameterPinion";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = LatexSymbols.BaseDiameterPinion;
    public string LatexFormula { get; set; } = LatexFormulae.BaseDiameterPinion;

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);

        var z1 = teethPinion.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z1 * m * Math.Cos(Radians(a));
    }
}