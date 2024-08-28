using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class PitchDiameter : GearParameter
{
    public PitchDiameter()
    {
        ParameterName = GearParameterName.PitchDiameter;
        Description = "Pitch Diameter";
        LatexSymbol = LatexSymbols.PitchDiameter;
        LatexFormula = LatexFormulae.PitchDiameter;
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

        return z * m;
    };
}