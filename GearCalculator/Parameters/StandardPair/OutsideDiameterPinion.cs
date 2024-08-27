using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterPinion : GearParameter
{
    public OutsideDiameterPinion()
    {
        ParameterName = GearParameterName.OutsideDiameterPinion;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameterPinion;
        LatexFormula = LatexFormulae.OutsideDiameterPinion;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));


        var z1 = teethPinion.Value;
        var m = module.Value;


        return z1 * m + 2 * m;
    }
}