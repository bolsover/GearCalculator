using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class RootDiameterWheel : GearParameter
{
    public RootDiameterWheel()
    {
        ParameterName = GearParameterName.RootDiameterWheel;
        Description = "Root Diameter";

        LatexSymbol = LatexSymbols.RootDiameterWheel; // @"d_{f2}";
        LatexFormula = LatexFormulae.RootDiameterWheel; //@"d{2}-2.5m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));

        var z2 = teethWheel.Value;
        var m = module.Value;


        return z2 * m - 2.5 * m;
    }
}