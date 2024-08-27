namespace Bolsover.GearCalculator.Dictionary;

public static class LatexFormulae
{
    public static readonly string Addendum = @"1.00m";
    public static readonly string Dedendum = @"1.25m";
    public static readonly string BaseDiameter = @"d\:cos\alpha";
    public static readonly string BaseDiameterPinion = @"d_{b1}\:cos\alpha";
    public static readonly string BaseDiameterWheel = @"d_{b2}\:cos\alpha";
    public static readonly string PseCentreDistanceIncrementFactor =
        @"\left(\frac{a_{x}}{m}\right)-\frac{\left(z_{1}+z_{2}\right)}{2}";
    public static readonly string InvoluteFunction = @"tan\alpha - \alpha";
    public static readonly string OutsideDiameter = @"d+2m";
    public static readonly string OutsideDiameterPinion = @"d_{1}+2m";
    public static readonly string OutsideDiameterWheel = @"d_{2}+2m";
    public static readonly string DifferenceCoefficientOfProfileShift =
        @"\frac{ \left(z_{2}-z_{1}\right)\left(inv\:\alpha_{w} - inv\:\alpha\right)
            }{2tan\:\alpha}";
    public static readonly string SumCoefficientOfProfileShift =
        @"\frac{ \left(z_{1}+z_{2}\right)\left(inv\:\alpha_{w} - inv\:\alpha\right)
            }{2tan\:\alpha}";
    public static readonly string ProfileShiftExtIntCentreDistanceIncrementFactor =
        @"\left(\frac{a_{x}}{m}\right)-\frac{\left(z_{2}+z_{1}\right)}{2}";
    public static readonly string PseAddendumPinion = @"\left(1+y-x_{2}\right)m";
    public static readonly string PseAddendumWheel = @"\left(1+y-x_{1}\right)m";
    public static readonly string PseDedendumWheel = @"h - h_{a2}";
    public static readonly string PseDedendumPinion = @"h - h_{a1}";
    public static readonly string PseiDedendumWheel = @"h - h_{a2}";
    public static readonly string PseiDedendumPinion = @"h - h_{a1}";
    public static readonly string PseiAddendumPinion = @"\left(1-x_{2}\right)m";
    public static readonly string PseiAddendumWheel = @"\left(1-x_{1}\right)m";
    public static readonly string PressureAngle = @" ";
    public static readonly string PseiInvoluteFunction =
        @"2 tan\alpha\left(\frac{x_{2}-x_{1}}{z_{2}-z_{1}}\right)+inv\alpha";
    public static readonly string PseiWorkingPressureAngle =
        @"cos^{-1}\left[\frac{\left(z_{2}-z_{1}\right)cos\:\alpha}{2y+z_{2}-z_{1}}\right]";

    public static readonly string PitchDiameter = @"zm";
    public static readonly string   PitchDiameterPinion = @"z_{1}m";
    public static readonly string   PitchDiameterWheel = @"z_{2}m";
    public static readonly string RootDiameterPinion  = @"d_{1}-2.5m";
    public static readonly string RootDiameterWheel  = @"d_{2}-2.5m";
    public static readonly string StandardCentreDistance = @"\frac{\left( z_{1} + z_{2} \right) m}{2}";
    public static readonly string WorkingPressureAngle  = @" cos^{-1}\left[\frac{\left(z_{1}+z_{2}\right)cos\:\alpha}{2y+z_{1}+z_{2}}\right]";
    public static readonly string WorkingInvoluteFunction = @"tan\alpha_{w} - \alpha_{w}";
}