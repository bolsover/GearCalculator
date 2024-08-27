using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class PitchDiameterWheel : GearParameter
{
    public PitchDiameterWheel()
    {
        ParameterName = GearParameterName.PitchDiameterWheel;
        Description = "PitchDiameterWheel";

        LatexSymbol = LatexSymbols.PitchDiameterWheel;
        LatexFormula = LatexFormulae.PitchDiameterWheel; //@"z_{2}m";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));

        var teethWheel = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel));

        var z = teethWheel.Value;

        var m = module.Value;

        return z * m;
    }
}