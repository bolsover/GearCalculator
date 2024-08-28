using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterWheel : GearParameter
{
    public OutsideDiameterWheel()
    {
        ParameterName = GearParameterName.OutsideDiameterWheel;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameterWheel;
        LatexFormula = LatexFormulae.OutsideDiameterWheel;
    }

    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }

    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z2 = parameters.TeethWheel.Value;

        return z2 * m + 2 * m;
    };
}