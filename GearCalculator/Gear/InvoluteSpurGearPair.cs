using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGearPair : Gear
{
    public readonly List<GearParameterName> Parameters = new()
    {
        GearParameterName.Module,
        GearParameterName.TeethPinion,
        GearParameterName.TeethWheel,
        GearParameterName.PressureAngle,
        GearParameterName.PitchDiameterPinion,
        GearParameterName.PitchDiameterWheel,
        GearParameterName.BaseDiameterPinion,
        GearParameterName.BaseDiameterWheel,
        GearParameterName.Addendum,
        GearParameterName.Dedendum,
        GearParameterName.OutsideDiameterPinion,
        GearParameterName.OutsideDiameterWheel,
        GearParameterName.RootDiameterPinion,
        GearParameterName.RootDiameterWheel, 
        GearParameterName.StandardCentreDistance
    };

    public InvoluteSpurGearPair()
    {
        DataDictionary = new GearDataDictionary(Parameters);
    }

    public override GearDataDictionary DataDictionary { get; set; }

    public override void Calculate()
    {
        CalculateParameterValue(GearParameterName.PitchDiameterPinion);
        CalculateParameterValue(GearParameterName.PitchDiameterWheel);
        CalculateParameterValue(GearParameterName.BaseDiameterPinion);
        CalculateParameterValue(GearParameterName.BaseDiameterWheel);
        CalculateParameterValue(GearParameterName.Addendum);
        CalculateParameterValue(GearParameterName.Dedendum);
        CalculateParameterValue(GearParameterName.OutsideDiameterPinion);
        CalculateParameterValue(GearParameterName.OutsideDiameterWheel);
        CalculateParameterValue(GearParameterName.RootDiameterPinion);
        CalculateParameterValue(GearParameterName.RootDiameterWheel);
        CalculateParameterValue(GearParameterName.StandardCentreDistance);
    }

    public override void CalculateParameterValue(GearParameterName parameterName)
    {
        DataDictionary.Value(parameterName, DataDictionary.RetrieveByName(parameterName).Calculate(DataDictionary));
    }
}