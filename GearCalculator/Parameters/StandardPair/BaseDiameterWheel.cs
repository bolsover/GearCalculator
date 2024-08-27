using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
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


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));
        var pressureAngle =
            parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle));


        var z2 = teethWheel.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z2 * m * Math.Cos(Radians(a));
    }
}