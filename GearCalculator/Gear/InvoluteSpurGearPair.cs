using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGearPair : Gear
{
  //  private readonly List<GearParameter> _parameters = new();

    public Addendum Addendum;
    public BaseDiameterPinion BaseDiameterPinion;
    public BaseDiameterWheel BaseDiameterWheel;
    public Dedendum Dedendum;
    public Module Module;
    public OutsideDiameterPinion OutsideDiameterPinion;
    public OutsideDiameterWheel OutsideDiameterWheel;
    public PitchDiameterPinion PitchDiameterPinion;
    public PitchDiameterWheel PitchDiameterWheel;
    public PressureAngle PressureAngle;
    public RootDiameterPinion RootDiameterPinion;
    public RootDiameterWheel RootDiameterWheel;
    public StandardCentreDistance StandardCentreDistance;
    public TeethPinion TeethPinion;
    public TeethWheel TeethWheel;
    public CalculationParameters CalculationParameters = new CalculationParameters();
    public List<GearParameter> GearParameters = new();

    public InvoluteSpurGearPair()
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
        GearParameters.Add(PitchDiameterPinion);
        GearParameters.Add(PitchDiameterWheel);
        GearParameters.Add(BaseDiameterPinion);
        GearParameters.Add(BaseDiameterWheel);
        GearParameters.Add(Addendum);
        GearParameters.Add(Dedendum);
        GearParameters.Add(OutsideDiameterPinion);
        GearParameters.Add(RootDiameterPinion);
        GearParameters.Add(RootDiameterWheel);
        GearParameters.Add(StandardCentreDistance);
    }

    private void InitCalculationParameters()
    {
        CalculationParameters.Module  = Module;
        CalculationParameters.TeethPinion  = TeethPinion;
        CalculationParameters.TeethWheel  = TeethWheel;    
        CalculationParameters.PressureAngle = PressureAngle;
    }

    private void InitParameters()
    {
        Module = new Module();
        TeethPinion = new TeethPinion();
        TeethWheel = new TeethWheel();
        PressureAngle = new PressureAngle();
        PitchDiameterPinion = new PitchDiameterPinion();
        PitchDiameterWheel = new PitchDiameterWheel();
        BaseDiameterPinion = new BaseDiameterPinion();
        BaseDiameterWheel = new BaseDiameterWheel();
        Addendum = new Addendum();
        Dedendum = new Dedendum();
        OutsideDiameterPinion = new OutsideDiameterPinion();
        OutsideDiameterWheel = new OutsideDiameterWheel();
        RootDiameterPinion = new RootDiameterPinion();
        RootDiameterWheel = new RootDiameterWheel();
        StandardCentreDistance = new StandardCentreDistance();
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 /Module.Value;
        TeethPinion.ImperialValue = TeethPinion.Value;
        TeethWheel.ImperialValue = TeethWheel.Value;
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(CalculationParameters);
        PitchDiameterPinion.ImperialValue = PitchDiameterPinion.Value/25.4;
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(CalculationParameters);
        PitchDiameterWheel.ImperialValue = PitchDiameterWheel.Value/25.4;
        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(CalculationParameters);
        BaseDiameterPinion.ImperialValue = BaseDiameterPinion.Value/25.4;
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(CalculationParameters);
        BaseDiameterWheel.ImperialValue = BaseDiameterWheel.Value/25.4;
        // Addendum.Value = Addendum.Calculate(_parameters);
        // Addendum.ImperialValue = Addendum.Value/25.4;
        // Dedendum.Value = Dedendum.Calculate(_parameters);
        // Dedendum.ImperialValue = Dedendum.Value/25.4;
        OutsideDiameterPinion.Value = OutsideDiameterPinion.Calculate(CalculationParameters);
        OutsideDiameterPinion.ImperialValue = OutsideDiameterPinion.Value/25.4;
        OutsideDiameterWheel.Value = OutsideDiameterWheel.Calculate(CalculationParameters);
        OutsideDiameterWheel.ImperialValue = OutsideDiameterWheel.Value/25.4;
        RootDiameterPinion.Value = RootDiameterPinion.Calculate(CalculationParameters);
        RootDiameterPinion.ImperialValue = RootDiameterPinion.Value/25.4;
        RootDiameterWheel.Value = RootDiameterWheel.Calculate(CalculationParameters);
        RootDiameterWheel.ImperialValue = RootDiameterWheel.Value/25.4;
        StandardCentreDistance.Value = StandardCentreDistance.Calculate(CalculationParameters);
        StandardCentreDistance.ImperialValue = StandardCentreDistance.Value/25.4;
    }
}