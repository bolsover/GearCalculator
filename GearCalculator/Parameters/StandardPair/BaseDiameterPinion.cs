using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class BaseDiameterPinion : GearParameter
{
    public BaseDiameterPinion()
    {
        ParameterName = GearParameterName.BaseDiameterPinion;
        Description = "Base Diameter";

        LatexSymbol = LatexSymbols.BaseDiameterPinion;
        LatexFormula = LatexFormulae.BaseDiameterPinion;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));
        var pressureAngle =
            parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle));

        var z1 = teethPinion.Value;
        var m = module.Value;
        var a = pressureAngle.Value;

        return z1 * m * Math.Cos(Radians(a));
    }
}