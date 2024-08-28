using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.PSEIPair;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;

namespace Bolsover.GearCalculator.Gear;

public sealed class ProfileShiftedExtIntSpurGearPair : Gear
{
    //input properties
    public readonly Module Module = new();
    public readonly TeethPinion TeethPinion = new();
    public readonly TeethWheel TeethWheel = new();
    public readonly WholeDepth WholeDepth = new();
    public readonly CoefficientProfileShiftPinion CoefficientProfileShiftPinion = new();
    public readonly CoefficientProfileShiftWheel CoefficientProfileShiftWheel = new();
    public readonly WorkingCentreDistance WorkingCentreDistance = new();

    // calculated properties
    public readonly BaseDiameterPinion BaseDiameterPinion = new();
    public readonly BaseDiameterWheel BaseDiameterWheel = new();
    public readonly PitchDiameterPinion PitchDiameterPinion = new();
    public readonly PitchDiameterWheel PitchDiameterWheel = new();
    public readonly PressureAngle PressureAngle = new();
    public readonly PseiAddendumPinion PseiAddendumPinion = new();
    public readonly PseiAddendumWheel PseiAddendumWheel = new();
    public readonly PseiCentreDistanceIncrementFactor PseiCentreDistanceIncrementFactor = new();
    public readonly PseiDedendumPinion PseiDedendumPinion = new();
    public readonly PseiDedendumWheel PseiDedendumWheel = new();
    public readonly PseiDifferenceCoefficientProfileShift PseiDifferenceCoefficientProfileShift = new();
    public readonly PseiInvoluteFunction PseiInvoluteFunction = new();
    public readonly PseiStandardCentreDistance PseiStandardCentreDistance = new();
    public readonly PseiWorkingPressureAngle PseiWorkingPressureAngle = new();

    


    public ProfileShiftedExtIntSpurGearPair()
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
        BaseDiameterPinion.Calc(CalculationParameters);
        BaseDiameterWheel.Calc(CalculationParameters);
        PseiStandardCentreDistance.Calc(CalculationParameters);
        PseiCentreDistanceIncrementFactor.Calc(CalculationParameters);
        PseiInvoluteFunction.Calc(CalculationParameters);
        PitchDiameterPinion.Calc(CalculationParameters);
        PitchDiameterWheel.Calc(CalculationParameters);
        PseiAddendumPinion.Calc(CalculationParameters);
        PseiAddendumWheel.Calc(CalculationParameters);
        WholeDepth.Calc(CalculationParameters);
        PseiDedendumPinion.Calc(CalculationParameters);
        PseiDedendumWheel.Calc(CalculationParameters);
        PseiDifferenceCoefficientProfileShift.Calc(CalculationParameters);
        PseiWorkingPressureAngle.Calc(CalculationParameters);
    }
}