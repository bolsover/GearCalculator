using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class StandardCentreDistance : GearParameter
{
    public StandardCentreDistance()
    {
        ParameterName = GearParameterName.StandardCentreDistance;
        Description = "Centre Distance";

        LatexSymbol = LatexSymbols.StandardCentreDistance;
        LatexFormula = LatexFormulae.StandardCentreDistance; //@"\frac{\left( z_{1} + z_{2} \right) m}{2}";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));
        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));

        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;

        return (z1 + z2) * m / 2;
    }
}