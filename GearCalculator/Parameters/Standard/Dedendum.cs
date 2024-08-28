using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Dedendum : GearParameter
{
    public Dedendum()
    {
        ParameterName = GearParameterName.Dedendum;
        Description = "Dedendum";

        LatexSymbol = LatexSymbols.Dedendum;
        LatexFormula = LatexFormulae.Dedendum;
    }

    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }

    private readonly Func<CalculationParameters, double> _calcValue = (parameters) => parameters.Module.Value * 1.25;
}