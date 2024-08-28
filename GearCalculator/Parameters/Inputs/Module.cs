using System;
using Bolsover.GearCalculator.Dictionary;

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


}