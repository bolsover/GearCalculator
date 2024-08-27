using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseAddendumPinion : GearParameter
{
    public PseAddendumPinion()
    {
        ParameterName = GearParameterName.PseAddendumPinion;
        Description = "PseAddendumPinion";

        LatexSymbol = LatexSymbols.AddendumPinion;
        LatexFormula = LatexFormulae.PseAddendumPinion; // @"\left(1+y-x_{2}\right)m";
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


        var y = ax / m - (z1 + z2) / 2; //centre distance increment factor

        return (1 + y - x2) * m;
    }
}