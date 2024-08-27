using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseDedendumPinion : GearParameter
{
    public PseDedendumPinion()
    {
        ParameterName = GearParameterName.PseDedendumPinion;
        Description = "PseDedendumPinion";

        LatexSymbol = LatexSymbols.DedendumPinion;
        LatexFormula = LatexFormulae.PseDedendumPinion; // 
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;
        var pressureAngle = parameters
            .Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle)).Value;
        var x1 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion)).Value;
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;


        var y = ax / m - (z1 + z2) / 2;

        var ha1 = (1 + y - x2) * m;

        var h = (2.25 + y - (x1 + x2)) * m;

        return h - ha1;
    }
}