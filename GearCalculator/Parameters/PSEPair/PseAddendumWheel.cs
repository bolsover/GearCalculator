using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumWheel : GearParameter
{
    public PseAddendumWheel()
    {
        ParameterName = GearParameterName.PseAddendumWheel;
        Description = "PseAddendumWheel";

        LatexSymbol = LatexSymbols.AddendumWheel;
        LatexFormula = LatexFormulae.PseAddendumWheel; // @"\left(1+y-x_{1}\right)m";
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

        return (1 + y - x1) * m;
    }
}