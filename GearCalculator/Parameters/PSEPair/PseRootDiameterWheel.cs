using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseRootDiameterWheel : GearParameter
{
    public PseRootDiameterWheel()
    {
        ParameterName = GearParameterName.PseRootDiameterWheel;
        Description = "PseRootDiameterWheel";

        LatexSymbol = LatexSymbols.RootDiameterWheel;
        LatexFormula = @"d_{a2}-2h";
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
        var ha2 = (1 + y - x1) * m;
        var d2 = z2 * m;
        var da2 = d2 + 2 * ha2;
        return da2 - 2 * h;
    }
}