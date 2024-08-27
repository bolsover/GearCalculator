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

    public List<GearParameter> Parameters = new();
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


    public ProfileShiftedExtIntSpurGearPair()
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


        Parameters.Add(Module);
        Parameters.Add(TeethPinion);
        Parameters.Add(TeethWheel);
        Parameters.Add(PressureAngle);
        Parameters.Add(WorkingCentreDistance);
        Parameters.Add(CoefficientProfileShiftPinion);
        Parameters.Add(CoefficientProfileShiftWheel);
        Parameters.Add(BaseDiameterPinion);
        Parameters.Add(BaseDiameterWheel);
        Parameters.Add(PseiStandardCentreDistance);
        Parameters.Add(PseiCentreDistanceIncrementFactor);
        Parameters.Add(PseiInvoluteFunction);
        Parameters.Add(PitchDiameterPinion);
        Parameters.Add(PitchDiameterWheel);
        Parameters.Add(PseiAddendumPinion);
        Parameters.Add(PseiAddendumWheel);
        Parameters.Add(WholeDepth);
        Parameters.Add(PseiDedendumPinion);
        Parameters.Add(PseiDedendumWheel);
        Parameters.Add(PseiDifferenceCoefficientProfileShift);
        Parameters.Add(PseiWorkingPressureAngle);
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 / Module.Value;
        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(Parameters);
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(Parameters);
        PseiStandardCentreDistance.Value = PseiStandardCentreDistance.Calculate(Parameters);
        PseiCentreDistanceIncrementFactor.Value = PseiCentreDistanceIncrementFactor.Calculate(Parameters);
        PseiInvoluteFunction.Value = PseiInvoluteFunction.Calculate(Parameters);
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(Parameters);
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(Parameters);
        PseiAddendumPinion.Value = PseiAddendumPinion.Calculate(Parameters);
        PseiAddendumWheel.Value = PseiAddendumWheel.Calculate(Parameters);
        WholeDepth.Value = WholeDepth.Calculate(Parameters);
        PseiDedendumPinion.Value = PseiDedendumPinion.Calculate(Parameters);
        PseiDedendumWheel.Value = PseiDedendumWheel.Calculate(Parameters);
        PseiDifferenceCoefficientProfileShift.Value = PseiDifferenceCoefficientProfileShift.Calculate(Parameters);
        PseiWorkingPressureAngle.Value = PseiWorkingPressureAngle.Calculate(Parameters);
    }
}