using System;
using System.Collections.Generic;
using Bolsover.GearCalculator.Dictionary;
using static Bolsover.GearCalculator.Utils.ConversionUtils;

namespace Bolsover.GearCalculator.Parameters.PSEPair;

public class PseWorkingPitchDiameterPinion : GearParameter
{
    public PseWorkingPitchDiameterPinion()
    {
        ParameterName = GearParameterName.PseWorkingPitchDiameterPinion;
        Description = "PseWorkingPitchDiameterPinion";

        LatexSymbol = LatexSymbols.WorkingPitchDiameterPinion; //"d_{w1}";
        LatexFormula = @"\frac{d_{b1}}{cos\alpha_{w}}";
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


        var alpha = Radians(pressureAngle); // pressure angle radians


        var y = ax / m - (z1 + z2) / 2; // centre distance increment factor

        var cosAlphaW = (z1 + z2) * Math.Cos(alpha) / (2 * y + z1 + z2); // cosine working pressure angle radians
        var db1 = z1 * m * Math.Cos(alpha);
        return db1 / cosAlphaW;
    }
}