using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
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


    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z = parameters.Teeth.Value;
        var a = parameters.PressureAngle.Value;

        return z * m * Math.Cos(Radians(a));
    };
}