using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class PitchDiameterWheel : GearParameter
{
    public PitchDiameterWheel()
    {
        ParameterName = GearParameterName.PitchDiameterWheel;
        Description = "PitchDiameterWheel";

        LatexSymbol = LatexSymbols.PitchDiameterWheel;
        LatexFormula = LatexFormulae.PitchDiameterWheel; //@"z_{2}m";
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

        return z2 * m;
    };
}