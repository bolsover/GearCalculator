﻿using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class OutsideDiameter : GearParameter
{
    public OutsideDiameter()
    {
        ParameterName = GearParameterName.OutsideDiameter;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameter; //@"d_{a}";
        LatexFormula = LatexFormulae.OutsideDiameter; //@"d+2m";
    }

    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }

    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z = parameters.Teeth.Value;

        return z * m + 2 * m;
    };
}