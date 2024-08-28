using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterPinion : GearParameter
{
    public OutsideDiameterPinion()
    {
        ParameterName = GearParameterName.OutsideDiameterPinion;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameterPinion;
        LatexFormula = LatexFormulae.OutsideDiameterPinion;
    }


    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;

        return z1 * m + 2 * m;
    };
}