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
    public List<GearParameter> GearParameters = new();
    public PitchDiameter PitchDiameter;
    public PressureAngle PressureAngle;
    public RootDiameter RootDiameter;
    public Teeth Teeth;
    public CalculationParameters CalculationParameters = new CalculationParameters();

    public InvoluteSpurGear()
    {
        InitParameters();
        InitCalculationParameters();
        InitParameterList();
    }

    private void InitParameterList()
    {
        GearParameters.Add(Module);
        GearParameters.Add(Teeth);
        GearParameters.Add(PressureAngle);
        GearParameters.Add(Addendum);
        GearParameters.Add(Dedendum);
        GearParameters.Add(PitchDiameter);
        GearParameters.Add(BaseDiameter);
        GearParameters.Add(RootDiameter);
        GearParameters.Add(OutsideDiameter);
    }

    private void InitCalculationParameters()
    {
        CalculationParameters.Module  = Module;
        CalculationParameters.Teeth  = Teeth;
        CalculationParameters.PressureAngle = PressureAngle;
    }

    private void InitParameters()
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
    }


    public override void Calculate()
    {
        Module.ImperialValue = 25.4 /Module.Value;
        Teeth.ImperialValue = Teeth.Value;
        PressureAngle.ImperialValue = PressureAngle.Value;
        PitchDiameter.Value = PitchDiameter.Calculate(CalculationParameters);
        PitchDiameter.ImperialValue = PitchDiameter.Value/25.4;
        BaseDiameter.Value = BaseDiameter.Calculate(CalculationParameters);
        BaseDiameter.ImperialValue = BaseDiameter.Value/25.4;
        Addendum.Value = Addendum.Calculate(CalculationParameters);
        Addendum.ImperialValue = Addendum.Value/25.4;
        Dedendum.Value = Dedendum.Calculate(CalculationParameters);
        Dedendum.ImperialValue =  Dedendum.Value/25.4;
        OutsideDiameter.Value = OutsideDiameter.Calculate(CalculationParameters);
        OutsideDiameter.ImperialValue = OutsideDiameter.Value/25.4;
        RootDiameter.Value = RootDiameter.Calculate(CalculationParameters);
        RootDiameter.ImperialValue = RootDiameter.Value/25.4;
    }
}