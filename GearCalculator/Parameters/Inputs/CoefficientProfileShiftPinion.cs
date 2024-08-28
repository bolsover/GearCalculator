using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class CoefficientProfileShiftPinion : GearParameter
{
    public CoefficientProfileShiftPinion()
    {
        ParameterName = GearParameterName.CoefficientProfileShiftPinion;
        Description = "Coefficient of Profile Shift";

        LatexSymbol = LatexSymbols.CoefficientOfProfileShiftPinion;
        LatexFormula = @"";
    }

    public void Calc(CalculationParameters parameters)
    {
       
        ImperialValue = Value;
      
    }
}