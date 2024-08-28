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
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z2 = parameters.TeethWheel.Value;

        return z2 * m;
    };
}