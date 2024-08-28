﻿using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseCentreDistanceIncrementFactor : GearParameter
{
    public PseCentreDistanceIncrementFactor()
    {
        ParameterName = GearParameterName.PseCentreDistanceIncrementFactor;
        Description = "Centre Distance Increment Factor";
        LatexSymbol = LatexSymbols.CentreDistanceIncrementFactor;
        LatexFormula = LatexFormulae.PseCentreDistanceIncrementFactor;
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
      //  ImperialValue = Value;
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;

        return ax / m - (z1 + z2) / 2;
    };
}