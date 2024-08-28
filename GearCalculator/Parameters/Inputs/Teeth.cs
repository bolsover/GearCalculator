using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

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

    public void Calc(CalculationParameters parameters)
    {
       
        ImperialValue = Value;
      
    }
}