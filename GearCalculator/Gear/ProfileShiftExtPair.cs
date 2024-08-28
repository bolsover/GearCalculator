using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.PSEPair;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;
using Bolsover.GearCalculatorUi.Utils;


namespace Bolsover.GearCalculator.Gear;

public sealed class ProfileShiftExtPair : Gear
{
    //input properties
    public readonly Module Module = new();
    public readonly TeethPinion TeethPinion = new();
    public readonly TeethWheel TeethWheel = new();
    public readonly PressureAngle PressureAngle = new();
    public readonly WorkingCentreDistance WorkingCentreDistance = new();
    public readonly CoefficientProfileShiftPinion CoefficientProfileShiftPinion = new();
    public readonly CoefficientProfileShiftWheel CoefficientProfileShiftWheel = new();

    // calculated properties
    public readonly BaseDiameterPinion BaseDiameterPinion = new();
    public readonly BaseDiameterWheel BaseDiameterWheel = new();
    public readonly InvoluteFunction InvoluteFunction = new();
    public readonly PitchDiameterPinion PitchDiameterPinion = new();
    public readonly PitchDiameterWheel PitchDiameterWheel = new();
    public readonly PseAddendumPinion PseAddendumPinion = new();
    public readonly PseAddendumWheel PseAddendumWheel = new();
    public readonly PseCentreDistanceIncrementFactor PseCentreDistanceIncrementFactor = new();
    public readonly PseDedendumPinion PseDedendumPinion = new();
    public readonly PseDedendumWheel PseDedendumWheel = new();
    public readonly PseOutsideDiameterPinion PseOutsideDiameterPinion = new();
    public readonly PseOutsideDiameterWheel PseOutsideDiameterWheel = new();
    public readonly PseRootDiameterPinion PseRootDiameterPinion = new();
    public readonly PseRootDiameterWheel PseRootDiameterWheel = new();
    public readonly PseTotalContactRatio PseTotalContactRatio = new();
    public readonly PseWholeDepth PseWholeDepth = new();
    public readonly PseWorkingPitchDiameterPinion PseWorkingPitchDiameterPinion = new();
    public readonly PseWorkingPitchDiameterWheel PseWorkingPitchDiameterWheel = new();
    public readonly StandardCentreDistance StandardCentreDistance = new();
    public readonly SumCoefficientProfileShift SumCoefficientProfileShift = new();
    public readonly WorkingInvoluteFunction WorkingInvoluteFunction = new();
    public readonly WorkingPressureAngle WorkingPressureAngle = new();

  
    public ProfileShiftExtPair()
    {
        InitCalculationParameters();
    }


    private void InitCalculationParameters()
    {
        CalculationParameters.Module = Module;
        CalculationParameters.TeethPinion = TeethPinion;
        CalculationParameters.TeethWheel = TeethWheel;
        CalculationParameters.PressureAngle = PressureAngle;
        CalculationParameters.WorkingCentreDistance = WorkingCentreDistance;
        CalculationParameters.CoefficientProfileShiftPinion = CoefficientProfileShiftPinion;
        CalculationParameters.CoefficientProfileShiftWheel = CoefficientProfileShiftWheel;
    }


    public void Calculate()
    {
        Module.Calc(CalculationParameters);
        Module.Notes = "DP = Diametral Pitch, CP = Circular Pitch";
        Module.AltValue = (Math.PI / (25.4 / Module.Value));
        PressureAngle.AltStringValue = SexagesimalAngle.FromDouble(PressureAngle.Value).ToString();
        WorkingPressureAngle.Calc(CalculationParameters);
        WorkingPressureAngle.AltStringValue = SexagesimalAngle.FromDouble(WorkingPressureAngle.Value).ToString();
        PseCentreDistanceIncrementFactor.Calc(CalculationParameters);
        SumCoefficientProfileShift.Calc(CalculationParameters);
        BaseDiameterPinion.Calc(CalculationParameters);
        BaseDiameterWheel.Calc(CalculationParameters);
        StandardCentreDistance.Calc(CalculationParameters);
        InvoluteFunction.Calc(CalculationParameters);
        PitchDiameterPinion.Calc(CalculationParameters);
        PitchDiameterWheel.Calc(CalculationParameters);
        PseAddendumPinion.Calc(CalculationParameters);
        PseAddendumWheel.Calc(CalculationParameters);
        PseDedendumPinion.Calc(CalculationParameters);
        PseDedendumWheel.Calc(CalculationParameters);
        PseOutsideDiameterPinion.Calc(CalculationParameters);
        PseOutsideDiameterWheel.Calc(CalculationParameters);
        PseRootDiameterPinion.Calc(CalculationParameters);
        PseRootDiameterWheel.Calc(CalculationParameters);
        PseWholeDepth.Calc(CalculationParameters);
        PseWorkingPitchDiameterPinion.Calc(CalculationParameters);
        PseWorkingPitchDiameterWheel.Calc(CalculationParameters);
        PseTotalContactRatio.Calc(CalculationParameters);
        SumCoefficientProfileShift.Calc(CalculationParameters);
        WorkingInvoluteFunction.Calc(CalculationParameters);
    }
}