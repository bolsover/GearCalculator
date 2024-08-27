using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseCentreDistanceIncrementFactor : GearParameter
{
    public PseCentreDistanceIncrementFactor()
    {
        ParameterName = GearParameterName.PseCentreDistanceIncrementFactor;
        Description = "Centre Distance Increment Factor";

        LatexSymbol = LatexSymbols.CentreDistanceIncrementFactor;
        LatexFormula = LatexFormulae.PseCentreDistanceIncrementFactor;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;


        return ax / m - (z1 + z2) / 2;
    }
}