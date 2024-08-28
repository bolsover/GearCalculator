using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Dedendum : GearParameter
{
    public Dedendum()
    {
        ParameterName = GearParameterName.Dedendum;
        Description = "Dedendum";

        LatexSymbol = LatexSymbols.Dedendum;
        LatexFormula = LatexFormulae.Dedendum;
    }


    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        return parameters.Module.Value * 1.25;

     
    };
}