using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;


namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiDifferenceCoefficientProfileShift : GearParameter
{
    public PseiDifferenceCoefficientProfileShift()
    {
        ParameterName = GearParameterName.PseiDifferenceCoefficientProfileShift;
        Description = "Difference Coefficient Profile Shift";
        LatexSymbol = LatexSymbols.DifferenceCoefficientOfProfileShift;
        LatexFormula = LatexFormulae.DifferenceCoefficientOfProfileShift;
    }

    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var alpha = Radians(parameters.PressureAngle.Value);

        var y = ax / m - (z2 - z1) / 2;
        var invAlpha = Math.Tan(alpha) - alpha;
        var alphaW = Math.Acos((z2 - z1) * Math.Cos(alpha) / (2 * y + z2 - z1));
        var invAlphaW = Math.Tan(alphaW) - alphaW;

        return (z2 - z1) * (invAlphaW - invAlpha) / (2 * Math.Tan(alpha));
    };
}