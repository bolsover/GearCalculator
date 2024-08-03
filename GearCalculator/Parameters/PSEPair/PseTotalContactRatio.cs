using System;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseTotalContactRatio : IGearParameter
{
    public string Name { get; set; } = "PseTotalContactRatio";
    public string Description { get; set; } = "PseTotalContactRatio";
    public double Value { get; set; }
    public string LatexSymbol { get; set; } = "d\\epsilon_{\\gamma}";

    public string LatexFormula { get; set; } =
        @"\frac{\sqrt{\left(\frac{d_{a1}}{2}\right)^{2} - \left(\frac{d_{b1}}{2}\right)^{2}} +
            \sqrt{\left(\frac{d_{a2}}{2}\right)^{2} - \left(\frac{d_{b2}}{2}\right)^{2}} -
            a_{x} \cdot sin \alpha_{w}}{\pi \cdot m \cdot cos\alpha}";

    public double Calculate(GearDataDictionary dataDictionary)
    {
        dataDictionary.TryGetValue(GearParameterName.Module, out var module);
        dataDictionary.TryGetValue(GearParameterName.TeethPinion, out var teethPinion);
        dataDictionary.TryGetValue(GearParameterName.TeethWheel, out var teethWheel);
        dataDictionary.TryGetValue(GearParameterName.WorkingCentreDistance, out var workingCentreDistance);
        dataDictionary.TryGetValue(GearParameterName.PressureAngle, out var pressureAngle);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftWheel,
            out var coefficientProfileShiftWheel);
        dataDictionary.TryGetValue(GearParameterName.CoefficientProfileShiftPinion,
            out var coefficientProfileShiftPinion);
        var alpha = Radians(pressureAngle.Value); //pressure angle in radians
        var z1 = teethPinion.Value;
        var z2 = teethWheel.Value;
        var m = module.Value;
        var ax = workingCentreDistance.Value;
        var x2 = coefficientProfileShiftWheel.Value;
        var x1 = coefficientProfileShiftPinion.Value;

        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor
        var alphaW =
            Math.Acos((z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2)); // Working Pressure Angle in radians
        var db2 = z2 * m * Math.Cos(alpha); // base diameter wheel
        var db1 = z1 * m * Math.Cos(alpha); // base diameter pinion
        var ha1 = (1 + y - x2) * m; // pinion addendum
        var ha2 = (1 + y - x1) * m; // wheel addendum
        var d1 = z1 * m; // pinion pitch diameter
        var d2 = z2 * m; // wheel pitch diameter
        var da1 = d1 + 2 * ha1; // pinion outside (addendum) diameter
        var da2 = d2 + 2 * ha2; // wheel outside (addendum) diameter

        var num1 = Math.Sqrt(Math.Pow(da1 / 2, 2) - Math.Pow(db1 / 2, 2));
        var num2 = Math.Sqrt(Math.Pow(da2 / 2, 2) - Math.Pow(db2 / 2, 2));
        var num3 = ax * Math.Sin(alphaW);
        var num4 = Math.PI * m * Math.Cos(alpha);
        var epsilon = (num1 + num2 - num3) / num4;
        return epsilon;
    }
}