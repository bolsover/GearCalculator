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
        Value = CalcValue(parameters);
       ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z = parameters.Teeth.Value;

        return z * m;
    };
}