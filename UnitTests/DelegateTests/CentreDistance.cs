using System;

namespace UnitTests.DelegateTests;

public class CentreDistance
{
  public delegate double Calculate(double m, double z1, double z2);

  public static double Ax1 (double m, double z1, double z2) => m * z1 + z1 * z2;
  public static double Ax2 (double m, double z1, double z2) => m * z1 * z1 * z2;

  private Func<double, double, double> calc = (m1, m2) => m1 - m2;
  
  
  
}