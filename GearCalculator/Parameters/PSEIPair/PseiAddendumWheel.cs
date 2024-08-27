using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEIPair;

public class PseiAddendumWheel : GearParameter
{
    public PseiAddendumWheel()
    {
        ParameterName = GearParameterName.PseiAddendumWheel;
        Description = "PseiAddendumWheel";
        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseiAddendumWheel; // @"\left(1-x_{2}\right)m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        var coefficientProfileShiftWheel = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel));

        var m = module.Value;
        var x2 = coefficientProfileShiftWheel.Value;

        return (1 - x2) * m;
    }
}