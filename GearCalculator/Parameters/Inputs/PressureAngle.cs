using System;
using Bolsover.GearCalculator.Dictionary;

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

    // public double Calculate(GearDataParameters dataParameters)
    // {
    //     throw new NotImplementedException();
    // }
}