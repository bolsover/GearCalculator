using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

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

    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        return module.Value;
    }
}