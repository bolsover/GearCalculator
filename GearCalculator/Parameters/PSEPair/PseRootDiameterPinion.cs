using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterPinion : GearParameter
{
    public PseRootDiameterPinion()
    {
        ParameterName = GearParameterName.PseRootDiameterPinion;
        Description = "PseRootDiameterPinion";

        LatexSymbol = LatexSymbols.RootDiameterPinion;
        LatexFormula = @"d_{a1}-2h";
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
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;

        var y = ax / m - (z1 + z2) / 2;

        var h = (2.25 + y - (x1 + x2)) * m;
        var ha1 = (1 + y - x2) * m;
        var d1 = z1 * m;
        var da1 = d1 + 2 * ha1;
        return da1 - 2 * h;
    }
}