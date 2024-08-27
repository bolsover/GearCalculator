using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class TeethWheel : GearParameter
{
    public TeethWheel()
    {
        ParameterName = GearParameterName.TeethWheel;
        Description = "Teeth";
        LatexSymbol = LatexSymbols.TeethWheel;
        LatexFormula = "";
    }

    public double Calculate(GearDataParameters dataParameters)
    {
        throw new NotImplementedException();
    }
}