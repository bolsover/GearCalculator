using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiAddendumPinion : GearParameter
{
    public PseiAddendumPinion()
    {
        ParameterName = GearParameterName.PseiAddendumPinion;
        Description = "PseiAddendumPinion";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiAddendumPinion; // @"\left(1-x_{2}\right)m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        var coefficientProfileShiftPinion = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion));


        var m = module.Value;
        var x1 = coefficientProfileShiftPinion.Value;

        return (1 + x1) * m;
    }
}