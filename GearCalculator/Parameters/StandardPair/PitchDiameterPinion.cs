using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

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

    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));

        var z = teethPinion.Value;

        var m = module.Value;

        return z * m;
    }
}