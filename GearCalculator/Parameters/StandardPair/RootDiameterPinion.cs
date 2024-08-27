using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterPinion : GearParameter
{
    public RootDiameterPinion()
    {
        ParameterName = GearParameterName.RootDiameterPinion;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameterPinion; //@"d_{f1}";
        LatexFormula = LatexFormulae.RootDiameterPinion; // @"d{1}-2.5m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethPinion = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion));

        var z1 = teethPinion.Value;
        var m = module.Value;


        return z1 * m - 2.5 * m;
    }
}