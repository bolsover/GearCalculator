using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiInvoluteFunction : GearParameter
{
    public PseiInvoluteFunction()
    {
        ParameterName = GearParameterName.PseiInvoluteFunction;
        Description = "Involute Function";

        LatexSymbol = LatexSymbols.PseiInvoluteFunction;
        LatexFormula = LatexFormulae.PseiInvoluteFunction;
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
    //    ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var alpha = Radians(parameters.PressureAngle.Value);
        var x1 = parameters.CoefficientProfileShiftPinion.Value;
        var x2 = parameters.CoefficientProfileShiftWheel.Value;
        var inva = Math.Tan(alpha) - alpha;
        var pseiInvoluteFunction = 2 * Math.Tan(alpha) * ((x2 - x1) / (z2 - z1)) + inva;
        
        return pseiInvoluteFunction;
    };
}