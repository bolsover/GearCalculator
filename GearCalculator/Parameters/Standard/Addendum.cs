using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class Addendum : GearParameter
{
    public Addendum()
    {
        ParameterName = GearParameterName.Addendum;
        Description = "Addendum";

        LatexSymbol = LatexSymbols.Addendum;
        LatexFormula = LatexFormulae.Addendum;
    }

  public readonly Func<CalculationParameters, double> Calculate = (parameters) => parameters.Module.Value;
}