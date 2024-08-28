using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class RootDiameter : GearParameter
{
    public RootDiameter()
    {
        ParameterName = GearParameterName.RootDiameter;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameter; //@"d_{f}";
        LatexFormula = @"d-2.5m";
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


        return z * m - 2.5 * m;
    };
}