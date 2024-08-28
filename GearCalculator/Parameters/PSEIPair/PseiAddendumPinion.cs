using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiAddendumPinion : GearParameter
{
    public PseiAddendumPinion()
    {
        ParameterName = GearParameterName.PseiAddendumPinion;
        Description = "Addendum";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiAddendumPinion; // @"\left(1-x_{2}\right)m";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var x1 = parameters.CoefficientProfileShiftPinion.Value;

        return (1 + x1) * m;
    };
}