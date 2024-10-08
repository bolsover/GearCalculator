﻿using System;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class TeethPinion : GearParameter
{
    public TeethPinion()
    {
        ParameterName = GearParameterName.TeethPinion;
        Description = "Teeth";
        LatexSymbol = LatexSymbols.TeethPinion;
        LatexFormula = "";
    }

   
    public void Calc(CalculationParameters calculationParameters)
    {
        ImperialValue = Value;
    }
}