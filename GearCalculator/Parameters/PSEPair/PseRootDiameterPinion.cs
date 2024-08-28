using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterPinion : GearParameter
{
    public PseRootDiameterPinion()
    {
        ParameterName = GearParameterName.PseRootDiameterPinion;
        Description = "Root Diameter";
        LatexSymbol = LatexSymbols.RootDiameterPinion;
        LatexFormula = @"d_{a1}-2h";
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
        var ha1 = (1 + y - x2) * m;
        var d1 = z1 * m;
        var da1 = d1 + 2 * ha1;
        
        return da1 - 2 * h;
    };
}