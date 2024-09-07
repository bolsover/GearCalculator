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
    public readonly AutoCalcMode AutoCalcMode = new ();

    // calculated properties
    public readonly BaseDiameterPinion BaseDiameterPinion = new();
    public readonly BaseDiameterWheel BaseDiameterWheel = new();
    public readonly InvoluteFunction InvoluteFunction = new();
    public readonly PitchDiameterPinion PitchDiameterPinion = new();
    public readonly PitchDiameterWheel PitchDiameterWheel = new();
    public readonly PseAddendumPinion AddendumPinion = new();
    public readonly PseAddendumWheel AddendumWheel = new();
    public readonly PseCentreDistanceIncrementFactor CentreDistanceIncrementFactor = new();
    public readonly PseDedendumPinion DedendumPinion = new();
    public readonly PseDedendumWheel DedendumWheel = new();
    public readonly PseOutsideDiameterPinion OutsideDiameterPinion = new();
    public readonly PseOutsideDiameterWheel OutsideDiameterWheel = new();
    public readonly PseRootDiameterPinion RootDiameterPinion = new();
    public readonly PseRootDiameterWheel RootDiameterWheel = new();
    public readonly PseTotalContactRatio TotalContactRatio = new();
    public readonly PseWholeDepth WholeDepth = new();
    public readonly PseWorkingPitchDiameterPinion WorkingPitchDiameterPinion = new();
    public readonly PseWorkingPitchDiameterWheel WorkingPitchDiameterWheel = new();
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
        CalculationParameters.AutoCalcMode = AutoCalcMode;
    }


    public void Calculate()
    {
        Module.Calc(CalculationParameters);
        WorkingCentreDistance.Calc(CalculationParameters);
        PressureAngle.Calc(CalculationParameters);
        WorkingPressureAngle.Calc(CalculationParameters);
        CentreDistanceIncrementFactor.Calc(CalculationParameters);
        SumCoefficientProfileShift.Calc(CalculationParameters);
        BaseDiameterPinion.Calc(CalculationParameters);
        BaseDiameterWheel.Calc(CalculationParameters);
        StandardCentreDistance.Calc(CalculationParameters);
        InvoluteFunction.Calc(CalculationParameters);
        PitchDiameterPinion.Calc(CalculationParameters);
        PitchDiameterWheel.Calc(CalculationParameters);
        AddendumPinion.Calc(CalculationParameters);
        AddendumWheel.Calc(CalculationParameters);
        DedendumPinion.Calc(CalculationParameters);
        DedendumWheel.Calc(CalculationParameters);
        OutsideDiameterPinion.Calc(CalculationParameters);
        OutsideDiameterWheel.Calc(CalculationParameters);
        RootDiameterPinion.Calc(CalculationParameters);
        RootDiameterWheel.Calc(CalculationParameters);
        WholeDepth.Calc(CalculationParameters);
        WorkingPitchDiameterPinion.Calc(CalculationParameters);
        WorkingPitchDiameterWheel.Calc(CalculationParameters);
        TotalContactRatio.Calc(CalculationParameters);
        SumCoefficientProfileShift.Calc(CalculationParameters);
        WorkingInvoluteFunction.Calc(CalculationParameters);
    }
}