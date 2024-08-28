using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseWorkingPitchDiameterPinion : GearParameter
{
    public PseWorkingPitchDiameterPinion()
    {
        ParameterName = GearParameterName.PseWorkingPitchDiameterPinion;
        Description = "Working Pitch Diameter";
        LatexSymbol = LatexSymbols.WorkingPitchDiameterPinion; //"d_{w1}";
        LatexFormula = @"\frac{d_{b1}}{cos\alpha_{w}}";
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
        var db1 = z1 * m * Math.Cos(alpha);
        
        return db1 / cosAlphaW;
    };
}