using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseWorkingPitchDiameterWheel : GearParameter
{
    public PseWorkingPitchDiameterWheel()
    {
        ParameterName = GearParameterName.PseWorkingPitchDiameterWheel;
        Description = "Working Pitch Diameter";
        LatexSymbol = LatexSymbols.WorkingPitchDiameterWheel; //"d_{w2}";
        LatexFormula = LatexFormulae.PseWorkingPitchDiameterWheel; //@"\frac{d_{b2}}{cos\alpha_{w}}";
    }


    public void Calc(CalculationParameters parameters)
    {
        Value = _calcValue(parameters);
        ImperialValue = CalcImperial(Value);
    }
    
    private readonly Func<CalculationParameters, double> _calcValue = (parameters) =>
    {
        var z1 = parameters.TeethPinion.Value;
        var z2 = parameters.TeethWheel.Value;
        var m = parameters.Module.Value;
        var ax = parameters.WorkingCentreDistance.Value;
        var pressureAngle = parameters.PressureAngle.Value;
        var alpha = Radians(pressureAngle); // pressure angle radians
        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor
        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2); // cosine working pressure angle radians
       
        var db2 = z2 * m * Math.Cos(alpha);
        return db2 / cosAlphaW;
    };
}