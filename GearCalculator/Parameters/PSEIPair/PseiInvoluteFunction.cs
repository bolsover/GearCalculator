using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiInvoluteFunction : GearParameter
{
    public PseiInvoluteFunction()
    {
        ParameterName = GearParameterName.PseiInvoluteFunction;
        Description = "PseiInvoluteFunction";

        LatexSymbol = LatexSymbols.PseiInvoluteFunction;
        LatexFormula = LatexFormulae.PseiInvoluteFunction;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var alpha = Radians(parameters
            .Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle)).Value);
        var x1 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion)).Value;
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;


      
        var inva = Math.Tan(alpha) - alpha;
        var pseiInvoluteFunction = 2 * Math.Tan(alpha) * ((x2 - x1) / (z2 - z1)) + inva;
        return pseiInvoluteFunction;
    }
}