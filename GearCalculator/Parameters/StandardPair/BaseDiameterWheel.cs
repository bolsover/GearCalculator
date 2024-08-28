using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class BaseDiameterWheel : GearParameter
{
    public BaseDiameterWheel()
    {
        ParameterName = GearParameterName.BaseDiameterWheel;
        Description = "Base Diameter";

        LatexSymbol = LatexSymbols.BaseDiameterWheel;
        LatexFormula = LatexFormulae.BaseDiameterWheel;
    }
    
    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }


    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z2 = parameters.TeethWheel.Value;
        var alpha = parameters.PressureAngle.Value;

        return z2 * m * Math.Cos(Radians(alpha));
    };
}