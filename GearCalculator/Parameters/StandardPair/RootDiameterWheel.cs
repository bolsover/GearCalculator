using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterWheel : GearParameter
{
    public RootDiameterWheel()
    {
        ParameterName = GearParameterName.RootDiameterWheel;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameterWheel; // @"d_{f2}";
        LatexFormula = LatexFormulae.RootDiameterWheel; //@"d{2}-2.5m";
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

        return z2 * m - 2.5 * m;
    };
}