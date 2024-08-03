using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Gear;

public sealed class ProfileShiftedExtIntSpurGearPair : Gear
{
    public readonly List<GearParameterName> Parameters = new()
    {
        // design parameters
        GearParameterName.Module,
        GearParameterName.TeethPinion,
        GearParameterName.TeethWheel,
        GearParameterName.PressureAngle,
        GearParameterName.WorkingCentreDistance,
        GearParameterName.CoefficientProfileShiftPinion,
        GearParameterName.CoefficientProfileShiftWheel,
        
        // calculated parameters
        // GearParameterName.BaseDiameterPinion,
        // GearParameterName.BaseDiameterWheel,
        // GearParameterName.StandardCentreDistance,
        GearParameterName.PseiCentreDistanceIncrementFactor,
        // GearParameterName.InvoluteFunction,
        // GearParameterName.PitchDiameterPinion,
        // GearParameterName.PitchDiameterWheel,
        // GearParameterName.PSEAddendumPinion,
        // GearParameterName.PseAddendumWheel,
        // GearParameterName.PseDedendumPinion,
        // GearParameterName.PseDedendumWheel,
        // GearParameterName.PseOutsideDiameterPinion,
        // GearParameterName.PseOutsideDiameterWheel,
        // GearParameterName.PseRootDiameterPinion,
        // GearParameterName.PseRootDiameterWheel,
        // GearParameterName.PseWholeDepth,
        // GearParameterName.PseWorkingPitchDiameterPinion,
        // GearParameterName.PseWorkingPitchDiameterWheel,
        // GearParameterName.PseTotalContactRatio,
         GearParameterName.PseiDifferenceCoefficientProfileShift,
        // GearParameterName.WorkingInvoluteFunction,
        // GearParameterName.WorkingPressureAngle


    };

    public ProfileShiftedExtIntSpurGearPair()
    {
        DataDictionary = new GearDataDictionary(Parameters);
    }

    public override GearDataDictionary DataDictionary { get; set; }

    public override void Calculate()
    {
        // CalculateParameterValue(GearParameterName.BaseDiameterPinion);
        // CalculateParameterValue(GearParameterName.BaseDiameterWheel);
        // CalculateParameterValue(GearParameterName.StandardCentreDistance);
        CalculateParameterValue(GearParameterName.PseiCentreDistanceIncrementFactor);
        // CalculateParameterValue(GearParameterName.InvoluteFunction);
        // CalculateParameterValue(GearParameterName.PitchDiameterPinion);
        // CalculateParameterValue(GearParameterName.PitchDiameterWheel);
        // CalculateParameterValue(GearParameterName.PSEAddendumPinion);
        // CalculateParameterValue(GearParameterName.PseAddendumWheel);
        // CalculateParameterValue(GearParameterName.PseDedendumPinion);
        // CalculateParameterValue(GearParameterName.PseDedendumWheel);
        // CalculateParameterValue(GearParameterName.PseOutsideDiameterPinion);
        // CalculateParameterValue(GearParameterName.PseOutsideDiameterWheel);
        // CalculateParameterValue(GearParameterName.PseRootDiameterPinion);
        // CalculateParameterValue(GearParameterName.PseRootDiameterWheel);
        // CalculateParameterValue(GearParameterName.PseTotalContactRatio);
        // CalculateParameterValue(GearParameterName.PseWholeDepth);
        // CalculateParameterValue(GearParameterName.PseWorkingPitchDiameterPinion);
        // CalculateParameterValue(GearParameterName.PseWorkingPitchDiameterWheel);
         CalculateParameterValue(GearParameterName.PseiDifferenceCoefficientProfileShift);
        // CalculateParameterValue(GearParameterName.WorkingInvoluteFunction);
        // CalculateParameterValue(GearParameterName.WorkingPressureAngle);
    }

    public override void CalculateParameterValue(GearParameterName parameterName)
    {
        DataDictionary.Value(parameterName, DataDictionary.RetrieveByName(parameterName).Calculate(DataDictionary));
    }
}