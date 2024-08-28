using System;
using NUnit.Framework;

namespace UnitTests.DelegateTests;

public class CentreDistanceTest
{
    private ConsoleIo io = new();

    [Test]
    public void TestCentreDistance()
    {
        var m = 3;
        var z1 = 12;
        var z2 = 24;
        var ax = new CentreDistance.Calculate((m, z1, z2) => (z1+z2)/2 *m);
        io.WriteLine(""+ax.Invoke(m, z1, z2));
        ax = new CentreDistance.Calculate((m, z1, z2) => (z1*z2)/2 *m);
        io.WriteLine("" + ax.Invoke(m, z1, z2));

        Delegate d1 =
            Delegate.CreateDelegate(typeof(CentreDistance.Calculate), typeof(CentreDistance), "Ax1");
        
        io.WriteLine(""+d1.DynamicInvoke(m, z1, z2));

    }
   
    
}