using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class AutoCalcMode : GearParameter
{
    public AutoCalcMode()
    {
        ParameterName = GearParameterName.CalcMethod;
        Description = "CalcMethod";
        LatexSymbol = "";
        LatexFormula = "";
        Value = 0d; 
       
    }
    
   
    
    public void Calc(CalculationParameters parameters)
    {
        
    }
    
}