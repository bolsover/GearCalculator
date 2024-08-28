using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
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


    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var pressureAngle = parameters.PressureAngle.Value;
        var alpha = Radians(pressureAngle);
        var y = ax / m - (z1 + z2) / 2;
        var invAlpha = Math.Tan(alpha) - alpha;
        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));
        var invAlphaW = Math.Tan(alphaW) - alphaW;

        return (z1 + z2) * (invAlphaW - invAlpha) / (2 * Math.Tan(alpha));
    };
}