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

    public CalculationParameters CalculationParameters = new CalculationParameters();
    public List<GearParameter> GearParameters = new();

    public ProfileShiftExtPair()
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
        GearParameters.Add(StandardCentreDistance);
        GearParameters.Add(PseCentreDistanceIncrementFactor);
        GearParameters.Add(InvoluteFunction);
        GearParameters.Add(PitchDiameterPinion);
        GearParameters.Add(PitchDiameterWheel);
        GearParameters.Add(PseAddendumPinion);
        GearParameters.Add(PseAddendumWheel);
        GearParameters.Add(PseDedendumPinion);
        GearParameters.Add(PseDedendumWheel);
        GearParameters.Add(PseOutsideDiameterPinion);
        GearParameters.Add(PseOutsideDiameterWheel);
        GearParameters.Add(PseRootDiameterPinion);
        GearParameters.Add(PseRootDiameterWheel);
        GearParameters.Add(PseWholeDepth);
        GearParameters.Add(PseWorkingPitchDiameterPinion);
        GearParameters.Add(PseWorkingPitchDiameterWheel);
        GearParameters.Add(PseTotalContactRatio);
        GearParameters.Add(SumCoefficientProfileShift);
        GearParameters.Add(WorkingInvoluteFunction);
        GearParameters.Add(WorkingPressureAngle);
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
        WorkingPressureAngle.Value = WorkingPressureAngle.Calculate(CalculationParameters);
        WorkingPressureAngle.AltStringValue = SexagesimalAngle.FromDouble(WorkingPressureAngle.Value).ToString();
        
        PseCentreDistanceIncrementFactor.Value = PseCentreDistanceIncrementFactor.Calculate(CalculationParameters);
        // PseCentreDistanceIncrementFactor.ImperialValue = PseCentreDistanceIncrementFactor.Value / 25.4;

        SumCoefficientProfileShift.Value = SumCoefficientProfileShift.Calculate(CalculationParameters);

        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(CalculationParameters);
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(CalculationParameters);
        StandardCentreDistance.Value = StandardCentreDistance.Calculate(CalculationParameters);
       
        InvoluteFunction.Value = InvoluteFunction.Calculate(CalculationParameters);
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(CalculationParameters);
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(CalculationParameters);
        PseAddendumPinion.Value = PseAddendumPinion.Calculate(CalculationParameters);
        PseAddendumWheel.Value = PseAddendumWheel.Calculate(CalculationParameters);
        PseDedendumPinion.Value = PseDedendumPinion.Calculate(CalculationParameters);
        PseDedendumWheel.Value = PseDedendumWheel.Calculate(CalculationParameters);
        PseOutsideDiameterPinion.Value = PseOutsideDiameterPinion.Calculate(CalculationParameters);
        PseOutsideDiameterWheel.Value = PseOutsideDiameterWheel.Calculate(CalculationParameters);
        PseRootDiameterPinion.Value = PseRootDiameterPinion.Calculate(CalculationParameters);
        PseRootDiameterWheel.Value = PseRootDiameterWheel.Calculate(CalculationParameters);
        PseWholeDepth.Value = PseWholeDepth.Calculate(CalculationParameters);
        PseWorkingPitchDiameterPinion.Value = PseWorkingPitchDiameterPinion.Calculate(CalculationParameters);
        PseWorkingPitchDiameterWheel.Value = PseWorkingPitchDiameterWheel.Calculate(CalculationParameters);
        PseTotalContactRatio.Value = PseTotalContactRatio.Calculate(CalculationParameters);
       // SumCoefficientProfileShift.Value = SumCoefficientProfileShift.Calculate(Parameters);
        WorkingInvoluteFunction.Value = WorkingInvoluteFunction.Calculate(CalculationParameters);
        
    }
}