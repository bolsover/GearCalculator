using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.Standard;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGear : Gear
{
    public Addendum Addendum;
    public BaseDiameter BaseDiameter;
    public Dedendum Dedendum;
    public Module Module;
    public OutsideDiameter OutsideDiameter;
    public List<GearParameter> Parameters = new();
    public PitchDiameter PitchDiameter;
    public PressureAngle PressureAngle;
    public RootDiameter RootDiameter;
    public Teeth Teeth;

    public InvoluteSpurGear()
    {
        Module = new Module();
        Teeth = new Teeth();
        PressureAngle = new PressureAngle();
        Addendum = new Addendum();
        Dedendum = new Dedendum();
        PitchDiameter = new PitchDiameter();
        BaseDiameter = new BaseDiameter();
        RootDiameter = new RootDiameter();
        OutsideDiameter = new OutsideDiameter();


        Parameters.Add(Module);
        Parameters.Add(Teeth);
        Parameters.Add(PressureAngle);
        Parameters.Add(Addendum);
        Parameters.Add(Dedendum);
        Parameters.Add(PitchDiameter);
        Parameters.Add(BaseDiameter);
        Parameters.Add(RootDiameter);
        Parameters.Add(OutsideDiameter);
    }


    //   public override GearDataDictionary DataDictionary { get; set; }

    public override void Calculate()
    {
        Module.ImperialValue = 25.4 /Module.Value;
        Teeth.ImperialValue = Teeth.Value;
        PressureAngle.ImperialValue = PressureAngle.Value;
        PitchDiameter.Value = PitchDiameter.Calculate(Parameters);
        PitchDiameter.ImperialValue = PitchDiameter.Value/25.4;
        BaseDiameter.Value = BaseDiameter.Calculate(Parameters);
        BaseDiameter.ImperialValue = BaseDiameter.Value/25.4;
        Addendum.Value = Addendum.Calculate(Parameters);
        Addendum.ImperialValue = Addendum.Value/25.4;
        Dedendum.Value = Dedendum.Calculate(Parameters);
        Dedendum.ImperialValue =  Dedendum.Value/25.4;
        OutsideDiameter.Value = OutsideDiameter.Calculate(Parameters);
        OutsideDiameter.ImperialValue = OutsideDiameter.Value/25.4;
        RootDiameter.Value = RootDiameter.Calculate(Parameters);
        RootDiameter.ImperialValue = RootDiameter.Value/25.4;
    }
}