using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterPinion : GearParameter
{
    public RootDiameterPinion()
    {
        ParameterName = GearParameterName.RootDiameterPinion;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameterPinion; //@"d_{f1}";
        LatexFormula = LatexFormulae.RootDiameterPinion; // @"d{1}-2.5m";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;

        return z1 * m - 2.5 * m;
    };
}