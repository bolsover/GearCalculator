using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseDedendumPinion : GearParameter
{
    public PseDedendumPinion()
    {
        ParameterName = GearParameterName.PseDedendumPinion;
        Description = "Dedendum";
        LatexSymbol = LatexSymbols.DedendumPinion;
        LatexFormula = LatexFormulae.PseDedendumPinion; 
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
        var pressureAngle = parameters.PressureAngle.Value;
        var x1 = parameters.CoefficientProfileShiftPinion.Value;
        var x2 = parameters.CoefficientProfileShiftWheel.Value;
        var y = ax / m - (z1 + z2) / 2;
        var ha1 = (1 + y - x2) * m;
        var h = (2.25 + y - (x1 + x2)) * m;

        return h - ha1;
    };
}