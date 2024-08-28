using Bolsover.GearCalculatorUi.Model;
using Bolsover.GearCalculatorUi.View;
using System.Windows.Forms;
using System;
using Bolsover.GearCalculatorUi.Utils;

namespace Bolsover.GearCalculatorUi.Presenter;

public class ProfileShiftGearPairPresenter
{
    private readonly ProfileShiftExtPairView _view;
    private ProfileShiftExtPairModel _model;

    public ProfileShiftGearPairPresenter(ProfileShiftExtPairView view)
    {
        _view = view;
        Init();
        SetupEventListeners();
    }

    private void ConvertDoubleToString(object sender, ConvertEventArgs cevent, string format)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value using specified format.
        cevent.Value = ((double)cevent.Value).ToString(format);
    }

    private void DoubleToDiametralPitch(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in D.P.");

    }
    
    private void DoubleToCircularPitch(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in C.P.");

    }
    
    private void DoubleToString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000");
     
    }

    private void DoubleTo4DecString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.0000");

    }

    private void DoubleTo6DecString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000000");

    }

    private void DoubleToImperial(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in");
      
    }

    private void Init()
    {
        _model = new ProfileShiftExtPairModel();
        _model.Gear.Calculate();
        var module = _model.Gear.Module;
        _view.mUD.Value = (decimal)module.Value;
        _view.mL.Text = module.Description;
        _view.mN.Text = module.Notes;
        _view.mS.Image = LatexUtils.CreateImageFromLatex(module.LatexSymbol);
        var moduleDPBinding = new Binding("Text", module, "ImperialValue");
        moduleDPBinding.Format += DoubleToDiametralPitch;
        _view.mDP.DataBindings.Add(moduleDPBinding);
        var moduleCPBinding = new Binding("Text", module, "AltValue");
        moduleCPBinding.Format += DoubleToCircularPitch;
        _view.mCP.DataBindings.Add(moduleCPBinding);

        var alpha = _model.Gear.PressureAngle;
        _view.alphaUD.Value = (decimal)alpha.Value;
        _view.alphaL.Text = alpha.Description;
        _view.alphaS.Image = LatexUtils.CreateImageFromLatex(alpha.LatexSymbol);
        var alphaBinding = new Binding("Text", alpha, "AltStringValue");
        _view.alphaI.DataBindings.Add(alphaBinding);

        var z1 = _model.Gear.TeethPinion;
        _view.z1UD.Value = (decimal)z1.Value;
        _view.zL.Text = z1.Description;
        _view.z1S.Image = LatexUtils.CreateImageFromLatex(z1.LatexSymbol);
        var z1Binding = new Binding("Text", z1, "Value");
        _view.z1I.DataBindings.Add(z1Binding);
        
        var z2 = _model.Gear.TeethWheel;
        _view.z2UD.Value = (decimal)z2.Value;
       // _view.zL.Text = z1.Description;
        _view.z2S.Image = LatexUtils.CreateImageFromLatex(z2.LatexSymbol);
        var z2Binding = new Binding("Text", z2, "Value");
        _view.z2I.DataBindings.Add(z2Binding);
        
        var x1 = _model.Gear.CoefficientProfileShiftPinion;
        _view.x1UD.Value = (decimal)x1.Value;
        _view.xL.Text = x1.Description;
        _view.x1S.Image = LatexUtils.CreateImageFromLatex(x1.LatexSymbol);
        var x1Binding = new Binding("Text", x1, "Value");
        x1Binding.Format+= DoubleToString;
        _view.x1I.DataBindings.Add(x1Binding);
        
        var x2 = _model.Gear.CoefficientProfileShiftWheel;
        _view.x2UD.Value = (decimal)x2.Value;
       // _view.xL.Text = x1.Description;
        _view.x2S.Image = LatexUtils.CreateImageFromLatex(x2.LatexSymbol);
        var x2Binding = new Binding("Text", x2, "Value");
        x2Binding.Format += DoubleToString;
        _view.x2I.DataBindings.Add(x2Binding);

        var ax = _model.Gear.WorkingCentreDistance;
        _view.axUD.Value = (decimal)ax.Value;
        _view.axL.Text = ax.Description;
        _view.axS.Image = LatexUtils.CreateImageFromLatex(ax.LatexSymbol);
        var axBinding = new Binding("Text", ax, "ImperialValue");
        axBinding.Format += DoubleToImperial;
        _view.axI.DataBindings.Add(axBinding);

        var alphaW = _model.Gear.WorkingPressureAngle;
        _view.alphaWL.Text = alphaW.Description;
        _view.alphaWS.Image = LatexUtils.CreateImageFromLatex(alphaW.LatexSymbol);
        _view.alphaWF.Image = LatexUtils.CreateImageFromLatex(alphaW.LatexFormula);
        var alphaWMBinding = new Binding("Text", alphaW, "Value");
        alphaWMBinding.Format += DoubleToString;
        _view.alphaWM.DataBindings.Add(alphaWMBinding);
        var alphaWIBinding = new Binding("Text", alphaW, "AltStringValue");
        _view.alphaWI.DataBindings.Add(alphaWIBinding);

        var invAlpha = _model.Gear.InvoluteFunction;
        _view.invAlphaL.Text = invAlpha.Description;
        _view.invAlphaS.Image = LatexUtils.CreateImageFromLatex(invAlpha.LatexSymbol);
        _view.invAlphaF.Image = LatexUtils.CreateImageFromLatex(invAlpha.LatexFormula);
        var invAlphaMBinding = new Binding("Text", invAlpha, "Value");
        invAlphaMBinding.Format += DoubleTo6DecString;
        _view.invAlphaM.DataBindings.Add(invAlphaMBinding);
        var invAlphaIBinding = new Binding("Text", invAlpha, "Value");
        invAlphaIBinding.Format += DoubleTo6DecString;
        _view.invAlphaI.DataBindings.Add(invAlphaIBinding);

        var invAlphaW = _model.Gear.WorkingInvoluteFunction;
        _view.invAlphaWL.Text = invAlphaW.Description;
        _view.invAlphaWS.Image = LatexUtils.CreateImageFromLatex(invAlphaW.LatexSymbol);
        _view.invAlphaWF.Image = LatexUtils.CreateImageFromLatex(invAlphaW.LatexFormula);
        var invAlphaWMBinding = new Binding("Text", invAlphaW, "Value");
        invAlphaWMBinding.Format += DoubleTo6DecString;
        _view.invAlphaWM.DataBindings.Add(invAlphaWMBinding);
        var invAlphaWIBinding = new Binding("Text", invAlphaW, "Value");
        invAlphaWIBinding.Format += DoubleTo6DecString;
        _view.invAlphaWI.DataBindings.Add(invAlphaWIBinding);

        var y = _model.Gear.CentreDistanceIncrementFactor;
        _view.yL.Text = y.Description;
        _view.yS.Image = LatexUtils.CreateImageFromLatex(y.LatexSymbol);
        _view.yF.Image = LatexUtils.CreateImageFromLatex(y.LatexFormula);
        var yMBinding = new Binding("Text", y, "Value");
        yMBinding.Format += DoubleTo6DecString;
        _view.yM.DataBindings.Add(yMBinding);
        var yIBinding = new Binding("Text", y, "Value");
        yIBinding.Format += DoubleTo6DecString;
        _view.yI.DataBindings.Add(yIBinding);

        var sigmaX = _model.Gear.SumCoefficientProfileShift;
        _view.sumXL.Text = sigmaX.Description;
        _view.sumXS.Image = LatexUtils.CreateImageFromLatex(sigmaX.LatexSymbol);
        _view.sumXF.Image = LatexUtils.CreateImageFromLatex(sigmaX.LatexFormula);
        var sumXMBinding = new Binding("Text", sigmaX, "Value");
        sumXMBinding.Format += DoubleTo6DecString;
        _view.sumXM.DataBindings.Add(sumXMBinding);
        var sumXIBinding = new Binding("Text", sigmaX, "Value");
        sumXIBinding.Format += DoubleTo6DecString;
        _view.sumXI.DataBindings.Add(sumXIBinding);


    }

    private void SetupEventListeners()
    {
        _view.EditMEvent += ViewOnEditMEvent;
        _view.EditZ1Event += ViewOnEditZ1Event;
        _view.EditZ2Event += ViewOnEditZ2Event;
        _view.EditAlphaEvent += ViewOnEditAlphaEvent;
        _view.EditX1Event += ViewOnEditX1Event;
        _view.EditX2Event += ViewOnEditX2Event;
        _view.EditAxEvent += ViewOnEditAxEvent;
        
    }

    private void ViewOnEditAxEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.WorkingCentreDistance.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditX2Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.CoefficientProfileShiftWheel.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditX1Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.CoefficientProfileShiftPinion.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditAlphaEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.PressureAngle.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditZ2Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.TeethWheel.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditZ1Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.TeethPinion.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditMEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.Module.Value = newValue;
        }

        _model.Gear.Calculate();
    }
}