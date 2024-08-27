using System;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters.Inputs;

public class WorkingCentreDistance : GearParameter
{
    public WorkingCentreDistance()
    {
        ParameterName = GearParameterName.WorkingCentreDistance;
        Description = "Working Centre Distance";

        LatexSymbol = LatexSymbols.WorkingCentreDistance;
        LatexFormula = @"";
    }


    public double Calculate(GearDataParameters dataParameters)
    {
        throw new NotImplementedException();
    }
}