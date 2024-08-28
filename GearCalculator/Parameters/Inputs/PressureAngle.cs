using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using Bolsover.GearCalculatorUi.Utils;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class PressureAngle : GearParameter
{
    public PressureAngle()
    {
        ParameterName = GearParameterName.PressureAngle;
        Description = "Pressure Angle";
        LatexSymbol = LatexSymbols.PressureAngle; //@"\alpha";
        LatexFormula = LatexFormulae.PressureAngle;
    }

    public void Calc(CalculationParameters parameters)
    {
       
        ImperialValue = Value;
        AltStringValue = SexagesimalAngle.FromDouble(Value).ToString();
      
    }
    
}