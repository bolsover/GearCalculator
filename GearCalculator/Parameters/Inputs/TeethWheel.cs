using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

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


    public void Calc(CalculationParameters calculationParameters)
    {
        ImperialValue = Value;
    }
}