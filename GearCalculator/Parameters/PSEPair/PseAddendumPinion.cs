using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumPinion : GearParameter
{
    public PseAddendumPinion()
    {
        ParameterName = GearParameterName.PseAddendumPinion;
        Description = "Addendum";

        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseAddendumPinion; // @"\left(1+y-x_{2}\right)m";
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
        var x2 = parameters.CoefficientProfileShiftWheel.Value;
        var y = ax / m - (z1 + z2) / 2; //centre distance increment factor

        return (1 + y - x2) * m;
    };
}