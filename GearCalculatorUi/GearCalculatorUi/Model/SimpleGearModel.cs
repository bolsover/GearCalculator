using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculatorUi.Model;

public class SimpleGearModel
{
    public readonly InvoluteSpurGear Gear = new();

    public SimpleGearModel()
    {
        Init();
    }


    private void Init()
    {
        Gear.Module.Value = 2.5d;
        Gear.Teeth.Value = 18;
        Gear.PressureAngle.Value = 20;
    }


}