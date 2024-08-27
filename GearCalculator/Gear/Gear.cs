using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;

namespace Bolsover.GearCalculator.Gear;

public abstract class Gear
{
    public List<GearParameter> Parameters { get; set; }
    public abstract void Calculate();
}