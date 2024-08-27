using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiDedendumWheel : GearParameter
{
    public PseiDedendumWheel()
    {
        ParameterName = GearParameterName.PseiDedendumWheel;
        Description = "PseiDedendumWheel";
        LatexSymbol = LatexSymbols.DedendumWheel;
        LatexFormula = LatexFormulae.PseiDedendumWheel; // @"\left(1-x_{2}\right)m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        var coefficientProfileShiftWheel = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel));

        var m = module.Value;
        var x2 = coefficientProfileShiftWheel.Value;

        var h = 2.25 * module.Value; //whole depth
        return h - (1 - x2) * m;
    }
}