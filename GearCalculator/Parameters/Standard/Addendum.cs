﻿using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Addendum : GearParameter
{
    public Addendum()
    {
        ParameterName = GearParameterName.Addendum;
        Description = "Addendum";
        LatexSymbol = LatexSymbols.Addendum;
        LatexFormula = LatexFormulae.Addendum;
    }
    
    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }



    private readonly Func<CalculationParameters, double> _calcValue = (parameters) => parameters.Module.Value;
}