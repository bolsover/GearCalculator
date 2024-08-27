using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

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


    public double Calculate(List<GearParameter> parameters)
    {
        var module = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module));


        return 2.25 * module.Value;
    }
}