using System.Collections.Generic;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.Standard;

namespace Bolsover.GearCalculator.Gear;

public sealed class InvoluteSpurGear : Gear
{
    // input parameters
    public readonly Module Module = new ();
    public readonly Teeth Teeth = new ();
    public readonly PressureAngle PressureAngle = new ();
    
    // calculated parameters
    public readonly Addendum Addendum = new ();
    public readonly BaseDiameter BaseDiameter = new ();
    public readonly Dedendum Dedendum = new ();
    public readonly OutsideDiameter OutsideDiameter = new ();
    public readonly PitchDiameter PitchDiameter = new ();
    public readonly RootDiameter RootDiameter = new ();
   

    public InvoluteSpurGear()
    {
     
        InitCalculationParameters();
      
    }


    private void InitCalculationParameters()
    {
        
        CalculationParameters.Module = Module;
        CalculationParameters.Teeth = Teeth;
        CalculationParameters.PressureAngle = PressureAngle;
    }
   


    public void Calculate()
    {
        Module.Calc(CalculationParameters);
        Teeth.Calc(CalculationParameters);
        PressureAngle.Calc(CalculationParameters);
        PitchDiameter.Calc(CalculationParameters);
        BaseDiameter.Calc(CalculationParameters);
        Addendum.Calc(CalculationParameters);
        Dedendum.Calc(CalculationParameters);
        OutsideDiameter.Calc(CalculationParameters);
        RootDiameter.Calc(CalculationParameters);
    }
}