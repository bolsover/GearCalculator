﻿using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterPinion : GearParameter
{
    public PseOutsideDiameterPinion()
    {
        ParameterName = GearParameterName.PseOutsideDiameterPinion;
        Description = "Outside Diameter";
        LatexSymbol = LatexSymbols.OutsideDiameterPinion;
        LatexFormula = @"d_{1}-2h_{a1}";
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
        var x2 = parameters.CoefficientProfileShiftWheel.Value;
        var y = ax / m - (z1 + z2) / 2;
        var ha1 = (1 + y - x2) * m;
        var d1 = z1 * m;
        return d1 + 2 * ha1;
    };
}