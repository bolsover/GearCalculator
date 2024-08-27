using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

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


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        return module.Value * 1.25;
    }
}