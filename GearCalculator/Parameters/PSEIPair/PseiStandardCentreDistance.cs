using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiStandardCentreDistance : GearParameter
{
    public PseiStandardCentreDistance()
    {
        ParameterName = GearParameterName.PseiStandardCentreDistance;
        Description = "Standard Centre Distance";

        LatexSymbol = LatexSymbols.StandardCentreDistance;
        LatexFormula = @"\frac{\left( z_{1} + z_{2} \right) m}{2}";
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

        return (z2 - z1) * m / 2;
    };
}