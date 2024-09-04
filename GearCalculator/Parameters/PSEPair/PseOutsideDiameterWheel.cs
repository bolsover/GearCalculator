using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterWheel : GearParameter
{
    public PseOutsideDiameterWheel()
    {
        ParameterName = GearParameterName.PseOutsideDiameterWheel;
        Description = "PseOutsideDiameterWheel";

        LatexSymbol = LatexSymbols.OutsideDiameterWheel;
        LatexFormula = LatexFormulae.PseOutsideDiameterWheel; // @"d_{2}-2h_{a2}";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var x1 = parameters.CoefficientProfileShiftPinion.Value;
        var y = ax / m - (z1 + z2) / 2;
        var ha2 = (1 + y - x1) * m;
        var d2 = z2 * m;
        
        return d2 + 2 * ha2;
    };
}