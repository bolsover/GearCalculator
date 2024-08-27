using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class SumCoefficientProfileShift : GearParameter
{
    public SumCoefficientProfileShift()
    {
        ParameterName = GearParameterName.SumCoefficientProfileShift;
        Description = "Sum Coefficient Profile Shift";

        LatexSymbol = LatexSymbols.SumCoefficientOfProfileShift;

        LatexFormula = LatexFormulae.SumCoefficientOfProfileShift;
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


        var y = ax / m - (z1 + z2) / 2;
        var invAlpha = Math.Tan(alpha) - alpha;
        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));
        var invAlphaW = Math.Tan(alphaW) - alphaW;

        return (z1 + z2) * (invAlphaW - invAlpha) / (2 * Math.Tan(alpha));
    }
}