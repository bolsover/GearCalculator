using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

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


    // public readonly Func<List<GearParameter>, double> Calculate = (parameters) =>
    // {
    //     var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
    //     var z = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Teeth)).Value;
    //
    //     return z * m;
    // };
    
    public readonly Func<CalculationParameters, double> Calculate = (parameters) =>
    {
        var m = parameters.Module.Value;
        var z = parameters.Teeth.Value;

        return z * m;
    };
}