using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiCentreDistanceIncrementFactor : GearParameter
{
    public PseiCentreDistanceIncrementFactor()
    {
        ParameterName = GearParameterName.PseiCentreDistanceIncrementFactor;
        Description = "Centre Distance Increment Factor";

        LatexSymbol = LatexSymbols.CentreDistanceIncrementFactor;
        LatexFormula = LatexFormulae.ProfileShiftExtIntCentreDistanceIncrementFactor;
    }

    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
       // ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;

        return ax / m - (z2 - z1) / 2;
    };
}