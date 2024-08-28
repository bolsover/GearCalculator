using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class TeethPinion : GearParameter
{
    public TeethPinion()
    {
        ParameterName = GearParameterName.TeethPinion;
        Description = "Teeth";

        LatexSymbol = LatexSymbols.TeethPinion;
        LatexFormula = "";
    }

    // public double Calculate(GearDataParameters dataParameters)
    // {
    //     throw new NotImplementedException();
    // }
}