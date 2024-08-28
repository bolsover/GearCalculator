using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class WorkingPitchDiameter : GearParameter
{
    public WorkingPitchDiameter()
    {
        ParameterName = GearParameterName.WorkingPitchDiameter;
        Description = "WorkingPitchDiameter";

        LatexSymbol = LatexSymbols.WorkingPitchDiameter; //@"d_{w}";
        LatexFormula = @"\frac{d_{b}}{cos\alpha_{w}} ";
    }


    // public double Calculate(GearDataParameters dataParameters)
    // {
    //     throw new NotImplementedException();
    // }
}