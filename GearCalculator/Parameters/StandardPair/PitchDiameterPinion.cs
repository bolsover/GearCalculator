using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class PitchDiameterPinion : GearParameter
{
    public PitchDiameterPinion()
    {
        ParameterName = GearParameterName.PitchDiameterPinion;
        Description = "Pitch Diameter";

        LatexSymbol = LatexSymbols.PitchDiameterPinion;
        LatexFormula = LatexFormulae.PitchDiameterPinion; //@"z_{1}m";
    }

    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z1 = parameters.TeethPinion.Value;


        return z1 * m;
    };
}