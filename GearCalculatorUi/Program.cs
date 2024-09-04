using System;
using System.Windows.Forms;
using Bolsover.GearCalculatorUi.View;

namespace GearCalculatorUi;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
       
        Application.Run(new SimpleGearForm()); 
        Application.Run(new StandardGearPairForm());
        Application.Run(new ProfileShiftExtPairForm());
    }
}