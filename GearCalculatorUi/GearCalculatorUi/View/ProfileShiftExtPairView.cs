using Bolsover.GearCalculatorUi.Presenter;
using System;
using System.Windows.Forms;

namespace Bolsover.GearCalculatorUi.View;

public partial class ProfileShiftExtPairView : UserControl
{
    public ProfileShiftGearPairPresenter Presenter;
    public ProfileShiftExtPairView()
    {
        InitializeComponent();
        Presenter = new ProfileShiftGearPairPresenter(this);
    }
    public event EventHandler EditMEvent;
    public event EventHandler EditZ1Event;
    public event EventHandler EditZ2Event;
    public event EventHandler EditAlphaEvent;
    public event EventHandler EditX1Event;
    public event EventHandler EditX2Event;
    public event EventHandler EditAxEvent;
    
    public event EventHandler AutoCalcModeEvent;

    private void mUD_ValueChanged(object sender, EventArgs e)
    {
        EditMEvent?.Invoke(sender, e);
    }

    private void alphaUD_ValueChanged(object sender, EventArgs e)
    {
        EditAlphaEvent?.Invoke(sender, e);
    }

    private void z1UD_ValueChanged(object sender, EventArgs e)
    {
        EditZ1Event?.Invoke(sender, e);
    }

    private void z2UD_ValueChanged(object sender, EventArgs e)
    {
        EditZ2Event?.Invoke(sender, e);
    }

    private void x1UD_ValueChanged(object sender, EventArgs e)
    {
        EditX1Event?.Invoke(sender, e);
    }

    private void x2UD_ValueChanged(object sender, EventArgs e)
    {
        EditX2Event?.Invoke(sender, e);
    }

    private void axUD_ValueChanged(object sender, EventArgs e)
    {
        EditAxEvent?.Invoke(sender, e);
    }

    private void autoCalcMode_CheckedChanged(object sender, EventArgs e)
    {
        AutoCalcModeEvent?.Invoke(sender, e);
    }
}