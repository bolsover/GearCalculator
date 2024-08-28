using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class CoefficientProfileShiftWheel : GearParameter
{
    public CoefficientProfileShiftWheel()
    {
        ParameterName = GearParameterName.CoefficientProfileShiftWheel;
        Description = "Coefficient of Profile Shift";

        LatexSymbol = LatexSymbols.CoefficientOfProfileShiftWheel;
        LatexFormula = @"";
    }

    public void Calc(CalculationParameters parameters)
    {
       
        ImperialValue = Value;
      
    }
   
}