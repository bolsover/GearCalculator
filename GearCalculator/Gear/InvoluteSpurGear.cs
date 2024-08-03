using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGear : Gear
{
    public readonly List<GearParameterName> Parameters = new()
    {
        GearParameterName.Module,
        GearParameterName.Teeth,
        GearParameterName.PressureAngle,
        GearParameterName.Addendum,
        GearParameterName.Dedendum,
        GearParameterName.PitchDiameter,
        GearParameterName.BaseDiameter,
        GearParameterName.OutsideDiameter,
        GearParameterName.RootDiameter
    };

    public InvoluteSpurGear()
    {
        DataDictionary = new GearDataDictionary(Parameters);
    }

    public override GearDataDictionary DataDictionary { get; set; }

    public override void Calculate()
    {
        CalculateParameterValue(GearParameterName.PitchDiameter);
        CalculateParameterValue(GearParameterName.BaseDiameter);
        CalculateParameterValue(GearParameterName.Addendum);
        CalculateParameterValue(GearParameterName.Dedendum);
        CalculateParameterValue(GearParameterName.OutsideDiameter);
        CalculateParameterValue(GearParameterName.RootDiameter);
    }

    public override void CalculateParameterValue(GearParameterName parameterName)
    {
        DataDictionary.Value(parameterName, DataDictionary.RetrieveByName(parameterName).Calculate(DataDictionary));
    }
}