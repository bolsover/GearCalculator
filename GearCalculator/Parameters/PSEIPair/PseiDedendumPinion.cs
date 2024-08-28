using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiDedendumPinion : GearParameter
{
    public PseiDedendumPinion()
    {
        ParameterName = GearParameterName.PseiDedendumPinion;
        Description = "Dedendum";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiDedendumPinion; // @"\left(1-x_{2}\right)m";
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
        var h = 2.25 * m; // whole depth
        return h - (1 + x1) * m;
    };
}