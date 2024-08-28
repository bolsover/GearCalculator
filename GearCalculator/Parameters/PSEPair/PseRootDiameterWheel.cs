using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterWheel : GearParameter
{
    public PseRootDiameterWheel()
    {
        ParameterName = GearParameterName.PseRootDiameterWheel;
        Description = "Root Diameter";
        LatexSymbol = LatexSymbols.RootDiameterWheel;
        LatexFormula = @"d_{a2}-2h";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var x1 = parameters.CoefficientProfileShiftPinion.Value;
        var x2 = parameters.CoefficientProfileShiftWheel.Value;
        var y = ax / m - (z1 + z2) / 2;
        var h = (2.25 + y - (x1 + x2)) * m;
        var ha2 = (1 + y - x1) * m;
        var d2 = z2 * m;
        var da2 = d2 + 2 * ha2;
       
        return da2 - 2 * h;
    };
}