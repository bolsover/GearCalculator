using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseTotalContactRatio : GearParameter
{
    public PseTotalContactRatio()
    {
        ParameterName = GearParameterName.PseTotalContactRatio;
        Description = "PseTotalContactRatio";

        LatexSymbol = LatexSymbols.TotalContactRatio; 

        LatexFormula =
            @"\frac{\sqrt{\left(\frac{d_{a1}}{2}\right)^{2} - \left(\frac{d_{b1}}{2}\right)^{2}} +
            \sqrt{\left(\frac{d_{a2}}{2}\right)^{2} - \left(\frac{d_{b2}}{2}\right)^{2}} -
            a_{x} \cdot sin \alpha_{w}}{\pi \cdot m \cdot cos\alpha}";
    }


    public double Calculate(List<GearParameter> parameters)
    {
        var z1 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethPinion)).Value;
        var z2 = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.TeethWheel)).Value;
        var m = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.Module)).Value;
        var ax = parameters.Find(parameter => parameter.ParameterName.Equals(GearParameterName.WorkingCentreDistance))
            .Value;
        var pressureAngle = parameters
            .Find(parameter => parameter.ParameterName.Equals(GearParameterName.PressureAngle)).Value;
        var x1 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftPinion)).Value;
        var x2 = parameters.Find(parameter =>
            parameter.ParameterName.Equals(GearParameterName.CoefficientProfileShiftWheel)).Value;


        var alpha = Radians(pressureAngle); //pressure angle in radians


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