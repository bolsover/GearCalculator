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
    public readonly AutoCalcMode AutoCalcMode = new ();

    // calculated properties
    public readonly BaseDiameterPinion BaseDiameterPinion = new();
    public readonly BaseDiameterWheel BaseDiameterWheel = new();
    public readonly PitchDiameterPinion PitchDiameterPinion = new();
    public readonly PitchDiameterWheel PitchDiameterWheel = new();
    public readonly PressureAngle PressureAngle = new();
    public readonly PseiAddendumPinion AddendumPinion = new();
    public readonly PseiAddendumWheel AddendumWheel = new();
    public readonly PseiCentreDistanceIncrementFactor CentreDistanceIncrementFactor = new();
    public readonly PseiDedendumPinion DedendumPinion = new();
    public readonly PseiDedendumWheel DedendumWheel = new();
    public readonly PseiDifferenceCoefficientProfileShift DifferenceCoefficientProfileShift = new();
    public readonly PseiInvoluteFunction InvoluteFunction = new();
    public readonly PseiStandardCentreDistance StandardCentreDistance = new();
    public readonly PseiWorkingPressureAngle WorkingPressureAngle = new();
    

    


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
        CalculationParameters.AutoCalcMode = AutoCalcMode;
    }


    public void Calculate()
    {
        Module.Calc(CalculationParameters);
        BaseDiameterPinion.Calc(CalculationParameters);
        BaseDiameterWheel.Calc(CalculationParameters);
        StandardCentreDistance.Calc(CalculationParameters);
        CentreDistanceIncrementFactor.Calc(CalculationParameters);
        InvoluteFunction.Calc(CalculationParameters);
        PitchDiameterPinion.Calc(CalculationParameters);
        PitchDiameterWheel.Calc(CalculationParameters);
        AddendumPinion.Calc(CalculationParameters);
        AddendumWheel.Calc(CalculationParameters);
        WholeDepth.Calc(CalculationParameters);
        DedendumPinion.Calc(CalculationParameters);
        DedendumWheel.Calc(CalculationParameters);
        DifferenceCoefficientProfileShift.Calc(CalculationParameters);
        WorkingPressureAngle.Calc(CalculationParameters);
        WorkingCentreDistance.Calc(CalculationParameters);
        
    }
}