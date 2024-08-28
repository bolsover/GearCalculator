using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGearPair : Gear
{
    //input properties
    public readonly Module Module = new();
    public readonly TeethPinion TeethPinion = new();
    public readonly TeethWheel TeethWheel = new();
    public readonly PressureAngle PressureAngle = new();

    // calculated properties
    public readonly Addendum Addendum = new();
    public readonly Dedendum Dedendum = new();
    public readonly PitchDiameterPinion PitchDiameterPinion = new();
    public readonly PitchDiameterWheel PitchDiameterWheel = new();
    public readonly BaseDiameterPinion BaseDiameterPinion = new();
    public readonly BaseDiameterWheel BaseDiameterWheel = new();
    public readonly OutsideDiameterPinion OutsideDiameterPinion = new();
    public readonly OutsideDiameterWheel OutsideDiameterWheel = new();
    public readonly RootDiameterPinion RootDiameterPinion = new();
    public readonly RootDiameterWheel RootDiameterWheel = new();
    public readonly StandardCentreDistance StandardCentreDistance = new();

    
    public InvoluteSpurGearPair()
    {
        InitCalculationParameters();
    }


    private void InitCalculationParameters()
    {
        CalculationParameters.Module = Module;
        CalculationParameters.TeethPinion = TeethPinion;
        CalculationParameters.TeethWheel = TeethWheel;
        CalculationParameters.PressureAngle = PressureAngle;
    }


    public void Calculate()
    {
        Module.Calc(CalculationParameters);
        TeethPinion.Calc(CalculationParameters);
        TeethWheel.Calc(CalculationParameters);
        PressureAngle.Calc(CalculationParameters);
        Addendum.Calc(CalculationParameters);
        Dedendum.Calc(CalculationParameters);
        PitchDiameterPinion.Calc(CalculationParameters);
        PitchDiameterWheel.Calc(CalculationParameters);
        BaseDiameterPinion.Calc(CalculationParameters);
        BaseDiameterWheel.Calc(CalculationParameters);
        OutsideDiameterPinion.Calc(CalculationParameters);
        OutsideDiameterWheel.Calc(CalculationParameters);
        RootDiameterPinion.Calc(CalculationParameters);
        RootDiameterWheel.Calc(CalculationParameters);
        StandardCentreDistance.Calc(CalculationParameters);
    }
}