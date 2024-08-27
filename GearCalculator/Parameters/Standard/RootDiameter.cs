using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class RootDiameter : GearParameter
{
    public RootDiameter()
    {
        ParameterName = GearParameterName.RootDiameter;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameter; //@"d_{f}";
        LatexFormula = @"d-2.5m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teeth = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Teeth));

        var z = teeth.Value;
        var m = module.Value;


        return z * m - 2.5 * m;
    }
}