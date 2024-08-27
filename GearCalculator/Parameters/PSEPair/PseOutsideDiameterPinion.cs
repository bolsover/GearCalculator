using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseOutsideDiameterPinion : GearParameter
{
    public PseOutsideDiameterPinion()
    {
        ParameterName = GearParameterName.PseOutsideDiameterPinion;
        Description = "PseOutsideDiameterWheel";

        LatexSymbol = LatexSymbols.OutsideDiameterPinion;
        LatexFormula = @"d_{1}-2h_{a1}";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;


        var y = ax / m - (z1 + z2) / 2;

        var ha1 = (1 + y - x2) * m;

        var d1 = z1 * m;
        return d1 + 2 * ha1;
    }
}