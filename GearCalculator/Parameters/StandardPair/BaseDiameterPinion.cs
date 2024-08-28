using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class BaseDiameterPinion : GearParameter
{
    public BaseDiameterPinion()
    {
        ParameterName = GearParameterName.BaseDiameterPinion;
        Description = "Base Diameter";

        LatexSymbol = LatexSymbols.BaseDiameterPinion;
        LatexFormula = LatexFormulae.BaseDiameterPinion;
    }

    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }

    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;
        var alpha = parameters.PressureAngle.Value;

        return z1 * m * Math.Cos(Radians(alpha));
    };
}