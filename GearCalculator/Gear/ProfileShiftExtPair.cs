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
    public BaseDiameterPinion BaseDiameterPinion;
    public BaseDiameterWheel BaseDiameterWheel;
    public CoefficientProfileShiftPinion CoefficientProfileShiftPinion;
    public CoefficientProfileShiftWheel CoefficientProfileShiftWheel;
    public InvoluteFunction InvoluteFunction;

    public Module Module;
    public new List<GearParameter> Parameters = new();
    public PitchDiameterPinion PitchDiameterPinion;
    public PitchDiameterWheel PitchDiameterWheel;
    public PressureAngle PressureAngle;
    public PseAddendumPinion PseAddendumPinion;
    public PseAddendumWheel PseAddendumWheel;
    public PseCentreDistanceIncrementFactor PseCentreDistanceIncrementFactor;
    public PseDedendumPinion PseDedendumPinion;
    public PseDedendumWheel PseDedendumWheel;
    public PseOutsideDiameterPinion PseOutsideDiameterPinion;
    public PseOutsideDiameterWheel PseOutsideDiameterWheel;
    public PseRootDiameterPinion PseRootDiameterPinion;
    public PseRootDiameterWheel PseRootDiameterWheel;
    public PseTotalContactRatio PseTotalContactRatio;
    public PseWholeDepth PseWholeDepth;
    public PseWorkingPitchDiameterPinion PseWorkingPitchDiameterPinion;
    public PseWorkingPitchDiameterWheel PseWorkingPitchDiameterWheel;
    public StandardCentreDistance StandardCentreDistance;
    public SumCoefficientProfileShift SumCoefficientProfileShift;
    public TeethPinion TeethPinion;
    public TeethWheel TeethWheel;
    public WorkingCentreDistance WorkingCentreDistance;
    public WorkingInvoluteFunction WorkingInvoluteFunction;
    public WorkingPressureAngle WorkingPressureAngle;


    public ProfileShiftExtPair()
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
        StandardCentreDistance = new StandardCentreDistance();
        PseCentreDistanceIncrementFactor = new PseCentreDistanceIncrementFactor();
        InvoluteFunction = new InvoluteFunction();
        PitchDiameterPinion = new PitchDiameterPinion();
        PitchDiameterWheel = new PitchDiameterWheel();
        PseAddendumPinion = new PseAddendumPinion();
        PseAddendumWheel = new PseAddendumWheel();
        PseDedendumPinion = new PseDedendumPinion();
        PseDedendumWheel = new PseDedendumWheel();
        PseOutsideDiameterPinion = new PseOutsideDiameterPinion();
        PseOutsideDiameterWheel = new PseOutsideDiameterWheel();
        PseRootDiameterPinion = new PseRootDiameterPinion();
        PseRootDiameterWheel = new PseRootDiameterWheel();
        PseWholeDepth = new PseWholeDepth();
        PseWorkingPitchDiameterPinion = new PseWorkingPitchDiameterPinion();
        PseWorkingPitchDiameterWheel = new PseWorkingPitchDiameterWheel();
        PseTotalContactRatio = new PseTotalContactRatio();
        SumCoefficientProfileShift = new SumCoefficientProfileShift();
        WorkingInvoluteFunction = new WorkingInvoluteFunction();
        WorkingPressureAngle = new WorkingPressureAngle();


        Parameters.Add(Module);
        Parameters.Add(TeethPinion);
        Parameters.Add(TeethWheel);
        Parameters.Add(PressureAngle);
        Parameters.Add(WorkingCentreDistance);
        Parameters.Add(CoefficientProfileShiftPinion);
        Parameters.Add(CoefficientProfileShiftWheel);
        Parameters.Add(BaseDiameterPinion);
        Parameters.Add(BaseDiameterWheel);
        Parameters.Add(StandardCentreDistance);
        Parameters.Add(PseCentreDistanceIncrementFactor);
        Parameters.Add(InvoluteFunction);
        Parameters.Add(PitchDiameterPinion);
        Parameters.Add(PitchDiameterWheel);
        Parameters.Add(PseAddendumPinion);
        Parameters.Add(PseAddendumWheel);
        Parameters.Add(PseDedendumPinion);
        Parameters.Add(PseDedendumWheel);
        Parameters.Add(PseOutsideDiameterPinion);
        Parameters.Add(PseOutsideDiameterWheel);
        Parameters.Add(PseRootDiameterPinion);
        Parameters.Add(PseRootDiameterWheel);
        Parameters.Add(PseWholeDepth);
        Parameters.Add(PseWorkingPitchDiameterPinion);
        Parameters.Add(PseWorkingPitchDiameterWheel);
        Parameters.Add(PseTotalContactRatio);
        Parameters.Add(SumCoefficientProfileShift);
        Parameters.Add(WorkingInvoluteFunction);
        Parameters.Add(WorkingPressureAngle);
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 / Module.Value;
        Module.Notes = "DP = Diametral Pitch, CP = Circular Pitch";
        Module.AltValue =  (Math.PI / (25.4 /  Module.Value));
        PressureAngle.AltStringValue = SexagesimalAngle.FromDouble(PressureAngle.Value).ToString();
        // CoefficientProfileShiftPinion.ImperialValue = CoefficientProfileShiftPinion.Value / 25.4;
        // CoefficientProfileShiftWheel.ImperialValue = CoefficientProfileShiftWheel.Value / 25.4;
        WorkingCentreDistance.ImperialValue = WorkingCentreDistance.Value / 25.4;
        WorkingPressureAngle.Value = WorkingPressureAngle.Calculate(Parameters);
        WorkingPressureAngle.AltStringValue = SexagesimalAngle.FromDouble(WorkingPressureAngle.Value).ToString();
        
        PseCentreDistanceIncrementFactor.Value = PseCentreDistanceIncrementFactor.Calculate(Parameters);
        // PseCentreDistanceIncrementFactor.ImperialValue = PseCentreDistanceIncrementFactor.Value / 25.4;

        SumCoefficientProfileShift.Value = SumCoefficientProfileShift.Calculate(Parameters);

        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(Parameters);
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(Parameters);
        StandardCentreDistance.Value = StandardCentreDistance.Calculate(Parameters);
       
        InvoluteFunction.Value = InvoluteFunction.Calculate(Parameters);
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(Parameters);
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(Parameters);
        PseAddendumPinion.Value = PseAddendumPinion.Calculate(Parameters);
        PseAddendumWheel.Value = PseAddendumWheel.Calculate(Parameters);
        PseDedendumPinion.Value = PseDedendumPinion.Calculate(Parameters);
        PseDedendumWheel.Value = PseDedendumWheel.Calculate(Parameters);
        PseOutsideDiameterPinion.Value = PseOutsideDiameterPinion.Calculate(Parameters);
        PseOutsideDiameterWheel.Value = PseOutsideDiameterWheel.Calculate(Parameters);
        PseRootDiameterPinion.Value = PseRootDiameterPinion.Calculate(Parameters);
        PseRootDiameterWheel.Value = PseRootDiameterWheel.Calculate(Parameters);
        PseWholeDepth.Value = PseWholeDepth.Calculate(Parameters);
        PseWorkingPitchDiameterPinion.Value = PseWorkingPitchDiameterPinion.Calculate(Parameters);
        PseWorkingPitchDiameterWheel.Value = PseWorkingPitchDiameterWheel.Calculate(Parameters);
        PseTotalContactRatio.Value = PseTotalContactRatio.Calculate(Parameters);
       // SumCoefficientProfileShift.Value = SumCoefficientProfileShift.Calculate(Parameters);
        WorkingInvoluteFunction.Value = WorkingInvoluteFunction.Calculate(Parameters);
        
    }
}