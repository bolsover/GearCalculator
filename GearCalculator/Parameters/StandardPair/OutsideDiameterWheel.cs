using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class OutsideDiameterWheel : GearParameter
{
    public OutsideDiameterWheel()
    {
        ParameterName = GearParameterName.OutsideDiameterWheel;
        Description = "Outside Diameter";

        LatexSymbol = LatexSymbols.OutsideDiameterWheel;
        LatexFormula = LatexFormulae.OutsideDiameterWheel;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));


        var z2 = teethWheel.Value;
        var m = module.Value;


        return z2 * m + 2 * m;
    }
}