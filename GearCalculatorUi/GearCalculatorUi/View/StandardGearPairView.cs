using System;
using System.Windows.Forms;
using Bolsover.GearCalculatorUi.Presenter;

namespace Bolsover.GearCalculatorUi.View;

public partial class StandardGearPairView : UserControl
{
    public StandardGearPairPresenter Presenter;

    public StandardGearPairView()
    {
        InitializeComponent();
        Presenter = new StandardGearPairPresenter(this);
    }

    public event EventHandler EditModuleEvent;
    public event EventHandler EditTeethPinionEvent;
    public event EventHandler EditTeethWheelEvent;
    public event EventHandler EditPressureAngleEvent;


    private void moduleNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditModuleEvent?.Invoke(sender, e);
    }


    private void teethPinionNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditTeethPinionEvent?.Invoke(sender, e);
    }

    private void pressureAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditPressureAngleEvent?.Invoke(sender, e);
    }


    private void teethWheelNnumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        EditTeethWheelEvent?.Invoke(sender, e);
    }

    private void label14_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}