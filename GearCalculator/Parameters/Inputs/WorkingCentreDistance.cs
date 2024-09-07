using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class WorkingCentreDistance : GearParameter
{
    public WorkingCentreDistance()
    {
        ParameterName = GearParameterName.WorkingCentreDistance;
        Description = "Working Centre Distance";

        LatexSymbol = LatexSymbols.WorkingCentreDistance;
        LatexFormula = @"";
    }

    public void Calc(CalculationParameters calculationParameters)
    {
        ImperialValue = Value/25.4;
    }
   
}