using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculatorUi.Model;

public class StandardGearPairModel
{
    public readonly InvoluteSpurGearPair Gear = new();

    public StandardGearPairModel()
    {
        Init();
    }


    private void Init()
    {
        Gear.Module.Value = 3.0d;
        Gear.TeethPinion.Value = 12;
        Gear.TeethWheel.Value = 24;
        Gear.PressureAngle.Value = 20;
    }


}