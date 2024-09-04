using Bolsover.GearCalculator.Gear;

namespace Bolsover.GearCalculatorUi.Model;

public class ProfileShiftExtPairModel
{
    public readonly ProfileShiftExtPair Gear = new();

    public ProfileShiftExtPairModel()
    {
        Init();
    }


    private void Init()
    {
        Gear.Module.Value = 3.0d;
        Gear.TeethPinion.Value = 12d;
        Gear.TeethWheel.Value = 24d;
        Gear.PressureAngle.Value = 20d;
        Gear.CoefficientProfileShiftPinion.Value = 0.6d;
        Gear.CoefficientProfileShiftWheel.Value = 0.36d;
        Gear.WorkingCentreDistance.Value = 56.4999d;
    }


}