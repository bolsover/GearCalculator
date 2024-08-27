using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiDedendumPinion : GearParameter
{
    public PseiDedendumPinion()
    {
        ParameterName = GearParameterName.PseiDedendumPinion;
        Description = "PseiDedendumPinion";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiDedendumPinion; // @"\left(1-x_{2}\right)m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        var coefficientProfileShiftPinion = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion));


        var m = module.Value;
        var x1 = coefficientProfileShiftPinion.Value;
        var h = 2.25 * module.Value; // whole depth
        return h - (1 + x1) * m;
    }
}