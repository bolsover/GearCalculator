using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiWorkingPressureAngle : GearParameter
{
    public PseiWorkingPressureAngle()
    {
        ParameterName = GearParameterName.PseiWorkingPressureAngle;
        Description = "PseiWorkingPressureAngle";

        LatexSymbol = LatexSymbols.WorkingPressureAngle; //  @"alpha_{w}";

        LatexFormula = LatexFormulae.PseiWorkingPressureAngle;
        // @" cos^{-1}\left[\frac{\left(z_{1}+z_{2}\right)cos\:\alpha}{2y+z_{1}+z_{2}}\right]";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));
        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));
        var workingCentreDistance = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance));
        var pressureAngle =
            parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle));

        var alpha = Radians(pressureAngle.Value);
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;

        var y = ax / m - (z2 - z1) / 2; // centre distance increment factor

        var cosAlphaW = (z2 - z1) * Math.Cos(alpha) / (2 * y + z2 - z1);
        return Degrees(Math.Acos(cosAlphaW));
    }
}