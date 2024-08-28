using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class Teeth : GearParameter
{
    public Teeth()
    {
        ParameterName = GearParameterName.Teeth;
        Description = "Teeth";
        LatexSymbol = LatexSymbols.Teeth;
        LatexFormula = "";
    }

    // public double Calculate(GearDataParameters dataParameters)
    // {
    //     throw new NotImplementedException();
    // }
}