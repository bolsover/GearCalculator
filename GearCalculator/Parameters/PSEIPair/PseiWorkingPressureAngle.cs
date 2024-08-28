using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiWorkingPressureAngle : GearParameter
{
    public PseiWorkingPressureAngle()
    {
        ParameterName = GearParameterName.PseiWorkingPressureAngle;
        Description = "Working Pressure Angle";
        LatexSymbol = LatexSymbols.WorkingPressureAngle; 
        LatexFormula = LatexFormulae.PseiWorkingPressureAngle;
      
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = Value;
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var alpha = Radians(parameters.PressureAngle.Value);
        var y = ax / m - (z2 - z1) / 2; // centre distance increment factor
        var cosAlphaW = (z2 - z1) * Math.Cos(alpha) / (2 * y + z2 - z1);
        
        return Degrees(Math.Acos(cosAlphaW));
    };
}