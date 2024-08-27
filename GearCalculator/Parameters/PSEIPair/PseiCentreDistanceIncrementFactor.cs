using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiCentreDistanceIncrementFactor : GearParameter
{
    public PseiCentreDistanceIncrementFactor()
    {
        ParameterName = GearParameterName.PseiCentreDistanceIncrementFactor;
        Description = "PseiCentreDistanceIncrementFactor";

        LatexSymbol = LatexSymbols.CentreDistanceIncrementFactor;
        LatexFormula = LatexFormulae.ProfileShiftExtIntCentreDistanceIncrementFactor;
    }

    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;


        return ax / m - (z2 - z1) / 2;
    }
}