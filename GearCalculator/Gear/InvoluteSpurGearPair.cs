using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGearPair : Gear
{
    private readonly List<GearParameter> _parameters = new();

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

    public InvoluteSpurGearPair()
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


        _parameters.Add(Module);
        _parameters.Add(TeethPinion);
        _parameters.Add(TeethWheel);
        _parameters.Add(PressureAngle);
        _parameters.Add(PitchDiameterPinion);
        _parameters.Add(PitchDiameterWheel);
        _parameters.Add(BaseDiameterPinion);
        _parameters.Add(BaseDiameterWheel);
        _parameters.Add(Addendum);
        _parameters.Add(Dedendum);
        _parameters.Add(OutsideDiameterPinion);
        _parameters.Add(RootDiameterPinion);
        _parameters.Add(RootDiameterWheel);
        _parameters.Add(StandardCentreDistance);
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 /Module.Value;
        TeethPinion.ImperialValue = TeethPinion.Value;
        TeethWheel.ImperialValue = TeethWheel.Value;
        PitchDiameterPinion.Value = PitchDiameterPinion.Calculate(_parameters);
        PitchDiameterPinion.ImperialValue = PitchDiameterPinion.Value/25.4;
        PitchDiameterWheel.Value = PitchDiameterWheel.Calculate(_parameters);
        PitchDiameterWheel.ImperialValue = PitchDiameterWheel.Value/25.4;
        BaseDiameterPinion.Value = BaseDiameterPinion.Calculate(_parameters);
        BaseDiameterPinion.ImperialValue = BaseDiameterPinion.Value/25.4;
        BaseDiameterWheel.Value = BaseDiameterWheel.Calculate(_parameters);
        BaseDiameterWheel.ImperialValue = BaseDiameterWheel.Value/25.4;
        Addendum.Value = Addendum.Calculate(_parameters);
        Addendum.ImperialValue = Addendum.Value/25.4;
        Dedendum.Value = Dedendum.Calculate(_parameters);
        Dedendum.ImperialValue = Dedendum.Value/25.4;
        OutsideDiameterPinion.Value = OutsideDiameterPinion.Calculate(_parameters);
        OutsideDiameterPinion.ImperialValue = OutsideDiameterPinion.Value/25.4;
        OutsideDiameterWheel.Value = OutsideDiameterWheel.Calculate(_parameters);
        OutsideDiameterWheel.ImperialValue = OutsideDiameterWheel.Value/25.4;
        RootDiameterPinion.Value = RootDiameterPinion.Calculate(_parameters);
        RootDiameterPinion.ImperialValue = RootDiameterPinion.Value/25.4;
        RootDiameterWheel.Value = RootDiameterWheel.Calculate(_parameters);
        RootDiameterWheel.ImperialValue = RootDiameterWheel.Value/25.4;
        StandardCentreDistance.Value = StandardCentreDistance.Calculate(_parameters);
        StandardCentreDistance.ImperialValue = StandardCentreDistance.Value/25.4;
    }
}