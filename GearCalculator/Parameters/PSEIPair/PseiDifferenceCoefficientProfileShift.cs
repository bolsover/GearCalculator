using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiDifferenceCoefficientProfileShift : GearParameter
{
    public PseiDifferenceCoefficientProfileShift()
    {
        ParameterName = GearParameterName.PseiDifferenceCoefficientProfileShift;
        Description = "PseiDifferenceCoefficientProfileShift";
        LatexSymbol = LatexSymbols.DifferenceCoefficientOfProfileShift;
        LatexFormula = LatexFormulae.DifferenceCoefficientOfProfileShift;
    }

    public double Calculate(List<GearParameter> parameters)
    {
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var ax = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance)).Value;
        var alpha =
            Radians(parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle))
                .Value);


        var y = ax / m - (z2 - z1) / 2;
        var invAlpha = Math.Tan(alpha) - alpha;
        var alphaW = Math.Acos((z2 - z1) * Math.Cos(alpha) / (2 * y + z2 - z1));
        var invAlphaW = Math.Tan(alphaW) - alphaW;

        return (z2 - z1) * (invAlphaW - invAlpha) / (2 * Math.Tan(alpha));
    }
}