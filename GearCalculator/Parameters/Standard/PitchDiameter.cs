using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class PitchDiameter : GearParameter
{
    public PitchDiameter()
    {
        ParameterName = GearParameterName.PitchDiameter;
        Description = "Pitch Diameter";
        LatexSymbol = LatexSymbols.PitchDiameter;
        LatexFormula = LatexFormulae.PitchDiameter;
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));
        var teeth = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Teeth));

        var z = teeth.Value;
        var m = module.Value;

        return z * m;
    }
}