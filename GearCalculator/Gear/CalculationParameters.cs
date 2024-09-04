using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;

namespace Bolsover.GearCalculator.Gear;

public class CalculationParameters
{
    private GearParameter _module;
    private GearParameter _teeth;
    private GearParameter _pressureAngle;
    private GearParameter _teethPinion;
    private GearParameter _teethWheel;
    private GearParameter _workingCentreDistance;
    private GearParameter _coefficientProfileShiftPinion;
    private GearParameter _coefficientProfileShiftWheel;
    private GearParameter _autoCalcMode;

    public GearParameter Module
    {
        get => _module;
        set => _module = value;
    }

    public GearParameter Teeth
    {
        get => _teeth;
        set => _teeth = value;
    }

    public GearParameter PressureAngle
    {
        get => _pressureAngle;
        set => _pressureAngle = value;
    }

    public GearParameter TeethPinion
    {
        get => _teethPinion;
        set => _teethPinion = value;
    }

    public GearParameter TeethWheel
    {
        get => _teethWheel;
        set => _teethWheel = value;
    }

    public GearParameter WorkingCentreDistance
    {
        get => _workingCentreDistance;
        set => _workingCentreDistance = value;
    }

    public GearParameter CoefficientProfileShiftPinion
    {
        get => _coefficientProfileShiftPinion;
        set => _coefficientProfileShiftPinion = value;
    }

    public GearParameter CoefficientProfileShiftWheel
    {
        get => _coefficientProfileShiftWheel;
        set => _coefficientProfileShiftWheel = value;
    }
    
    public GearParameter AutoCalcMode
    {
        get => _autoCalcMode;
        set => _autoCalcMode = value;
    }
}