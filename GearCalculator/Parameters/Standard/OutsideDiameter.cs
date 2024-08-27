using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class OutsideDiameter : GearParameter
{
    public OutsideDiameter()
    {
        ParameterName = GearParameterName.OutsideDiameter;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameter; //@"d_{a}";
        LatexFormula = LatexFormulae.OutsideDiameter; //@"d+2m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teeth = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Teeth));

        var z = teeth.Value;
        var m = module.Value;


        return z * m + 2 * m;
    }
}