using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculator.Parameters.Standard;

public class WholeDepth : GearParameter
{
    public WholeDepth()
    {
        ParameterName = GearParameterName.WholeDepth;
        Description = "WholeDepth";
        LatexSymbol = LatexSymbols.WholeDepth; //@"h";
        LatexFormula = @"2.25m";
    }


    public readonly Func<CalculationParameters, double> Calculate = (parameters) => parameters.Module.Value * 2.25;
}