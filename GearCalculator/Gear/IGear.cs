using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Gear;

public abstract class Gear
{
    private List<GearParameterName> Parameters { get; set; }
    public abstract GearDataDictionary DataDictionary { get; set; }
    public abstract void Calculate();
    public abstract void CalculateParameterValue(GearParameterName parameterName);
}