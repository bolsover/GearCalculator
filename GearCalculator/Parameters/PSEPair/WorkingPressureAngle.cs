using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
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
         
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = Value;
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var pressureAngle = parameters.PressureAngle.Value;
        var alpha = Radians(pressureAngle);

        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2);
        return Degrees(Math.Acos(cosAlphaW));
    };
}