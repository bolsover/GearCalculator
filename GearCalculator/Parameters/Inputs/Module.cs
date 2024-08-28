using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class Module : GearParameter
{
    public Module()
    {
        ParameterName = GearParameterName.Module;
        Description = "Module";
        LatexSymbol = LatexSymbols.Module;
        LatexFormula = "";
    }

    
    public void Calc(CalculationParameters parameters)
    {
       
        ImperialValue = 25.4/Value;
        Notes = "DP = Diametral Pitch, CP = Circular Pitch";
        AltValue = Math.PI / (25.4 / Value);
      
    }

}