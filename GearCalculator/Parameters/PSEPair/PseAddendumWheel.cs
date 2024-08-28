using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumWheel : GearParameter
{
    public PseAddendumWheel()
    {
        ParameterName = GearParameterName.PseAddendumWheel;
        Description = "Addendum";

        LatexSymbol = LatexSymbols.AddendumWheel;
        LatexFormula = LatexFormulae.PseAddendumWheel; // @"\left(1+y-x_{1}\right)m";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = CalcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    public readonly Func<CalculationParameters, double> CalcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var x1 = parameters.CoefficientProfileShiftPinion.Value;
        var y = ax / m - (z1 + z2) / 2;

        return (1 + y - x1) * m;
    };
}