using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.PSEIPair;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;

namespace Bolsover.GearCalculator.Gear;

public sealed class ProfileShiftedExtIntSpurGearPair : Gear
{
    public BaseDiameterPinion BaseDiameterPinion;
    public BaseDiameterWheel BaseDiameterWheel;
    public CoefficientProfileShiftPinion CoefficientProfileShiftPinion;
    public CoefficientProfileShiftWheel CoefficientProfileShiftWheel;
    public Module Module;
    public PitchDiameterPinion PitchDiameterPinion;
    public PitchDiameterWheel PitchDiameterWheel;
    public PressureAngle PressureAngle;
    public PseiAddendumPinion PseiAddendumPinion;
    public PseiAddendumWheel PseiAddendumWheel;
    public PseiCentreDistanceIncrementFactor PseiCentreDistanceIncrementFactor;
    public PseiDedendumPinion PseiDedendumPinion;
    public PseiDedendumWheel PseiDedendumWheel;
    public PseiDifferenceCoefficientProfileShift PseiDifferenceCoefficientProfileShift;
    public PseiInvoluteFunction PseiInvoluteFunction;
    public PseiStandardCentreDistance PseiStandardCentreDistance;
    public PseiWorkingPressureAngle PseiWorkingPressureAngle;
    public TeethPinion TeethPinion;
    public TeethWheel TeethWheel;
    public WholeDepth WholeDepth;
    public WorkingCentreDistance WorkingCentreDistance;
    public CalculationParameters CalculationParameters = new CalculationParameters();
    public List<GearParameter> GearParameters = new();


    public ProfileShiftedExtIntSpurGearPair()
    {
        InitParameters();
        InitCalculationParameters();
        InitParameterList();
    }

    private void InitParameterList()
    {
        
        GearParameters.Add(Module);
        GearParameters.Add(TeethPinion);
        GearParameters.Add(TeethWheel);
        GearParameters.Add(PressureAngle);
        GearParameters.Add(WorkingCentreDistance);
        GearParameters.Add(CoefficientProfileShiftPinion);
        GearParameters.Add(CoefficientProfileShiftWheel);
        GearParameters.Add(BaseDiameterPinion);
        GearParameters.Add(BaseDiameterWheel);
        GearParameters.Add(PseiStandardCentreDistance);
        GearParameters.Add(PseiCentreDistanceIncrementFactor);
        GearParameters.Add(PseiInvoluteFunction);
        GearParameters.Add(PitchDiameterPinion);
        GearParameters.Add(PitchDiameterWheel);
        GearParameters.Add(PseiAddendumPinion);
        GearParameters.Add(PseiAddendumWheel);
        GearParameters.Add(WholeDepth);
        GearParameters.Add(PseiDedendumPinion);
        GearParameters.Add(PseiDedendumWheel);
        GearParameters.Add(PseiDifferenceCoefficientProfileShift);
        GearParameters.Add(PseiWorkingPressureAngle);
    }

    private void InitCalculationParameters()
    {
        CalculationParameters.Module  = Module;
        CalculationParameters.TeethPinion  = TeethPinion;
        CalculationParameters.TeethWheel  = TeethWheel;    
        CalculationParameters.PressureAngle = PressureAngle;
        CalculationParameters.WorkingCentreDistance = WorkingCentreDistance;
        CalculationParameters.CoefficientProfileShiftPinion = CoefficientProfileShiftPinion;
        CalculationParameters.CoefficientProfileShiftWheel = CoefficientProfileShiftWheel;
    }

    private void InitParameters()
    {
        Module = new Module();
        TeethPinion = new TeethPinion();
        TeethWheel = new TeethWheel();
        PressureAngle = new PressureAngle();
        WorkingCentreDistance = new WorkingCentreDistance();
        CoefficientProfileShiftPinion = new CoefficientProfileShiftPinion();
        CoefficientProfileShiftWheel = new CoefficientProfileShiftWheel();
        BaseDiameterPinion = new BaseDiameterPinion();
        BaseDiameterWheel = new BaseDiameterWheel();
        PseiStandardCentreDistance = new PseiStandardCentreDistance();
        PseiCentreDistanceIncrementFactor = new PseiCentreDistanceIncrementFactor();
        PseiInvoluteFunction = new PseiInvoluteFunction();
        PitchDiameterPinion = new PitchDiameterPinion();
        PitchDiameterWheel = new PitchDiameterWheel();
        PseiAddendumPinion = new PseiAddendumPinion();
        PseiAddendumWheel = new PseiAddendumWheel();
        WholeDepth = new WholeDepth();
        PseiDedendumPinion = new PseiDedendumPinion();
        PseiDedendumWheel = new PseiDedendumWheel();
        PseiDifferenceCoefficientProfileShift = new PseiDifferenceCoefficientProfileShift();
        PseiWorkingPressureAngle = new PseiWorkingPressureAngle();
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 / Module.Value;
        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(CalculationParameters);
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(CalculationParameters);
        PseiStandardCentreDistance.Value = PseiStandardCentreDistance.Calculate(CalculationParameters);
        PseiCentreDistanceIncrementFactor.Value = PseiCentreDistanceIncrementFactor.Calculate(CalculationParameters);
        PseiInvoluteFunction.Value = PseiInvoluteFunction.Calculate(CalculationParameters);
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(CalculationParameters);
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(CalculationParameters);
        PseiAddendumPinion.Value = PseiAddendumPinion.Calculate(CalculationParameters);
        PseiAddendumWheel.Value = PseiAddendumWheel.Calculate(CalculationParameters);
        WholeDepth.Value = WholeDepth.Calculate(CalculationParameters);
        PseiDedendumPinion.Value = PseiDedendumPinion.Calculate(CalculationParameters);
        PseiDedendumWheel.Value = PseiDedendumWheel.Calculate(CalculationParameters);
        PseiDifferenceCoefficientProfileShift.Value = PseiDifferenceCoefficientProfileShift.Calculate(CalculationParameters);
        PseiWorkingPressureAngle.Value = PseiWorkingPressureAngle.Calculate(CalculationParameters);
    }
}