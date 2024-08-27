using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class WorkingPressureAngle : GearParameter
{
    public WorkingPressureAngle()
    {
        ParameterName = GearParameterName.WorkingPressureAngle;
        Description = "Working Pressure Angle";

        LatexSymbol = LatexSymbols.WorkingPressureAngle; //@"alpha_{w}";

        LatexFormula = LatexFormulae.WorkingPressureAngle;
          //  @" cos^{-1}\left[\frac{\left(z_{1}+z_{2}\right)cos\:\alpha}{2y+z_{1}+z_{2}}\right]";
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
        var x1 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion)).Value;
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;


        var alpha = Radians(pressureAngle);


        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2);
        return Degrees(Math.Acos(cosAlphaW));
    }
}