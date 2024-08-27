using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
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


    public double Calculate(List<GearParameter> parameters)
    {
        var pressureAngle = parameters
            .Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle)).Value;

        var alpha = Radians(pressureAngle);
        return Math.Tan(alpha) - alpha;
    }
}