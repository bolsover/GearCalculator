using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiAddendumWheel : GearParameter
{
    public PseiAddendumWheel()
    {
        ParameterName = GearParameterName.PseiAddendumWheel;
        Description = "Addendum";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiAddendumWheel; // @"\left(1-x_{2}\right)m";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var x2 = parameters.CoefficientProfileShiftWheel.Value;

        return (1 - x2) * m;
    };
}