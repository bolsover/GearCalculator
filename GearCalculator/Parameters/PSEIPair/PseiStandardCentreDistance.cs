using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiStandardCentreDistance : GearParameter
{
    public PseiStandardCentreDistance()
    {
        ParameterName = GearParameterName.PseiStandardCentreDistance;
        Description = "PseiStandardCentreDistance";

        LatexSymbol = LatexSymbols.StandardCentreDistance;
        LatexFormula = @"\frac{\left( z_{1} + z_{2} \right) m}{2}";
    }

    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;


        return (z2 - z1) * m / 2;
    }
}