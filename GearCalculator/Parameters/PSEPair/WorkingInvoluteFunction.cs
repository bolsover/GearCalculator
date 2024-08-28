using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class WorkingInvoluteFunction : GearParameter
{
    public WorkingInvoluteFunction()
    {
        ParameterName = GearParameterName.WorkingInvoluteFunction;
        Description = "Working Involute Function";
        LatexSymbol = LatexSymbols.WorkingInvoluteFunction; // @"inv\:\alpha_{w}";
        LatexFormula = LatexFormulae.WorkingInvoluteFunction; //@"tan\alpha_{w} - \alpha_{w}";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
    
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var pressureAngle = parameters.PressureAngle.Value;
        var alpha = Radians(pressureAngle);
        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor
        var alphaW = Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2));

        return Math.Tan(alphaW) - alphaW;
    };
}