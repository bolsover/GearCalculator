using System;
using System.Windows.Forms;
using Bolsover.GearCalculatorUi.Presenter;

namespace Bolsover.GearCalculatorUi.View;

public partial class SimpleGearView : UserControl
{
    public SimpleGearPresenter Presenter;

    public SimpleGearView()
    {
        InitializeComponent();
        Presenter = new SimpleGearPresenter(this);
    }

    public event EventHandler EditModuleEvent;
    public event EventHandler EditTeethEvent;
    public event EventHandler EditPressureAngleEvent;


    private void moduleNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditModuleEvent?.Invoke(sender, e);
    }


    private void teethNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditTeethEvent?.Invoke(sender, e);
    }

    private void pressureAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditPressureAngleEvent?.Invoke(sender, e);
    }

    
}