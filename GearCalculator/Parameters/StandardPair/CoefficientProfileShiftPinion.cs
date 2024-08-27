using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.StandardPair;

public class CoefficientProfileShiftPinion : GearParameter
{
    public CoefficientProfileShiftPinion()
    {
        ParameterName = GearParameterName.CoefficientProfileShiftPinion;
        Description = "Coefficient of Profile Shift";

        LatexSymbol = LatexSymbols.CoefficientOfProfileShiftPinion;
        LatexFormula = @"";
    }


    public double Calculate(GearDataParameters dataParameters)
    {
        throw new NotImplementedException();
    }
}