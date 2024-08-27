using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class CoefficientProfileShiftWheel : GearParameter
{
    public CoefficientProfileShiftWheel()
    {
        ParameterName = GearParameterName.CoefficientProfileShiftWheel;
        Description = "CoefficientProfileShiftWheel";

        LatexSymbol = LatexSymbols.CoefficientOfProfileShiftWheel;
        LatexFormula = @"";
    }


    public double Calculate(GearDataParameters dataParameters)
    {
        throw new NotImplementedException();
    }
}