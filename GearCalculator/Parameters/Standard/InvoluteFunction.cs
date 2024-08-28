using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.Standard;

public class InvoluteFunction : GearParameter
{
    public InvoluteFunction()
    {
        ParameterName = GearParameterName.InvoluteFunction;
        Description = "Involute Function";
        LatexSymbol = LatexSymbols.InvoluteFunction; //@"inv\:\alpha";
        LatexFormula = LatexFormulae.InvoluteFunction;
    }
    
    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        // ImperialValue = CalcImperial(Value);
    }


    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var pressureAngle = parameters.PressureAngle.Value;
        var alpha = Radians(pressureAngle);
        return Math.Tan(alpha) - alpha;
    };
}