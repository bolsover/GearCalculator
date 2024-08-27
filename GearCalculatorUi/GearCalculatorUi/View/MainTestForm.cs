using System;
using System.Windows.Forms;

namespace Bolsover.GearCalculatorUi.View;

public partial class MainTestForm : Form
{
    public MainTestForm()
    {
        InitializeComponent();
    }

    private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SimpleGearForm sf = new SimpleGearForm();
        sf.Show();
    }

    private void pairToolStripMenuItem_Click(object sender, EventArgs e)
    {
        StandardGearPairForm sf = new StandardGearPairForm();
        sf.Show();
    }

    private void profileShiftPairToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProfileShiftExtPairForm sf = new ProfileShiftExtPairForm();
        sf.Show();
    }
}