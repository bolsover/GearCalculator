using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class BaseDiameter : GearParameter
{
    public BaseDiameter()
    {
        ParameterName = GearParameterName.BaseDiameter;
        Description = "Base Diameter";

        LatexSymbol = LatexSymbols.BaseDiameter;
        LatexFormula = LatexFormulae.BaseDiameter;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teeth = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Teeth));
        var pressureAngle =
            parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle));


        var z = teeth.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z * m * Math.Cos(Radians(a));
    }
}