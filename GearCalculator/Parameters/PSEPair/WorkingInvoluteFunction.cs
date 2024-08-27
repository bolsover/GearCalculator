using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class WorkingInvoluteFunction : GearParameter
{
    public WorkingInvoluteFunction()
    {
        ParameterName = GearParameterName.WorkingInvoluteFunction;
        Description = "Working Involute Function";

        LatexSymbol = LatexSymbols.WorkingInvoluteFunction; // @"inv\:\alpha_{w}";
        LatexFormula = LatexFormulae.WorkingInvoluteFunction; //@"tan\alpha_{w} - \alpha_{w}";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;
        var pressureAngle = parameters
            .Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle)).Value;

        var alpha = Radians(pressureAngle);

        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));


        return Math.Tan(alphaW) - alphaW;
    }
}