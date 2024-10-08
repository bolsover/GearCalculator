﻿using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class StandardCentreDistance : GearParameter
{
    public StandardCentreDistance()
    {
        ParameterName = GearParameterName.StandardCentreDistance;
        Description = "Centre Distance";

        LatexSymbol = LatexSymbols.StandardCentreDistance;
        LatexFormula = LatexFormulae.StandardCentreDistance; 
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;

        return (z1 + z2) * m / 2;
    };
}