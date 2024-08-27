using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterWheel : GearParameter
{
    public PseOutsideDiameterWheel()
    {
        ParameterName = GearParameterName.PseOutsideDiameterWheel;
        Description = "PseOutsideDiameterWheel";

        LatexSymbol = LatexSymbols.DedendumWheel;
        LatexFormula = @"d_{2}-2h_{a2}";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;

        var x1 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion)).Value;


        var y = ax / m - (z1 + z2) / 2;

        var ha2 = (1 + y - x1) * m;

        var d2 = z2 * m;
        return d2 + 2 * ha2;
    }
}