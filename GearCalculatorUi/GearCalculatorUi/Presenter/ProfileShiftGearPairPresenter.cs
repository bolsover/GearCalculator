using Bolsover.GearCalculatorUi.Model;
using Bolsover.GearCalculatorUi.View;
using System.Windows.Forms;
using System;
using Bolsover.GearCalculator.Parameters.Inputs;
using Bolsover.GearCalculator.Parameters.PSEPair;
using Bolsover.GearCalculator.Parameters.Standard;
using Bolsover.GearCalculator.Parameters.StandardPair;
using Bolsover.GearCalculatorUi.Utils;

namespace Bolsover.GearCalculatorUi.Presenter;

public class ProfileShiftGearPairPresenter
{
    private readonly ProfileShiftExtPairView _view;
    private ProfileShiftExtPairModel _model;
    
    private Module module;
    private PressureAngle alpha;
    private TeethPinion z1;
    private TeethWheel z2;
    private CoefficientProfileShiftWheel x2;
    private CoefficientProfileShiftPinion x1;
    private WorkingCentreDistance ax;
    private WorkingPressureAngle alphaW;
    private InvoluteFunction invAlpha;
    private WorkingInvoluteFunction invAlphaW;
    private PseCentreDistanceIncrementFactor y;
    private SumCoefficientProfileShift sigmaX;
    private PitchDiameterPinion d1;
    private PitchDiameterWheel d2;
    private BaseDiameterPinion db1;
    private BaseDiameterWheel db2;
    private PseWorkingPitchDiameterPinion dw1;
    private PseWorkingPitchDiameterWheel dw2;
    private PseAddendumPinion ha1;
    private PseAddendumWheel ha2;
    private PseDedendumPinion hf1;
    private PseDedendumWheel hf2;
    private PseWholeDepth h;
    private PseOutsideDiameterPinion da1;
    private PseOutsideDiameterWheel da2;
    private PseRootDiameterPinion df1;
    private PseRootDiameterWheel df2;
    private PseTotalContactRatio eg;

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
        
        InitParameters();


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

        
        _view.alphaUD.Value = (decimal)alpha.Value;
        _view.alphaL.Text = alpha.Description;
        _view.alphaS.Image = LatexUtils.CreateImageFromLatex(alpha.LatexSymbol);
        var alphaBinding = new Binding("Text", alpha, "AltStringValue");
        _view.alphaI.DataBindings.Add(alphaBinding);
        
        _view.z1UD.Value = (decimal)z1.Value;
        _view.zL.Text = z1.Description;
        _view.z1S.Image = LatexUtils.CreateImageFromLatex(z1.LatexSymbol);
        var z1Binding = new Binding("Text", z1, "Value");
        _view.z1I.DataBindings.Add(z1Binding);
        
        
        _view.z2UD.Value = (decimal)z2.Value;
       // _view.zL.Text = z1.Description;
        _view.z2S.Image = LatexUtils.CreateImageFromLatex(z2.LatexSymbol);
        var z2Binding = new Binding("Text", z2, "Value");
        _view.z2I.DataBindings.Add(z2Binding);
        
        
        _view.x1UD.Value = (decimal)x1.Value;
        _view.xL.Text = x1.Description;
        _view.x1S.Image = LatexUtils.CreateImageFromLatex(x1.LatexSymbol);
        var x1Binding = new Binding("Text", x1, "Value");
        x1Binding.Format+= DoubleToString;
        _view.x1I.DataBindings.Add(x1Binding);
        
        
        _view.x2UD.Value = (decimal)x2.Value;
       // _view.xL.Text = x1.Description;
        _view.x2S.Image = LatexUtils.CreateImageFromLatex(x2.LatexSymbol);
        var x2Binding = new Binding("Text", x2, "Value");
        x2Binding.Format += DoubleToString;
        _view.x2I.DataBindings.Add(x2Binding);

        
        _view.axUD.Value = (decimal)ax.Value;
        _view.axL.Text = ax.Description;
        _view.axS.Image = LatexUtils.CreateImageFromLatex(ax.LatexSymbol);
        var axBinding = new Binding("Text", ax, "ImperialValue");
        axBinding.Format += DoubleToImperial;
        _view.axI.DataBindings.Add(axBinding);

        
        _view.alphaWL.Text = alphaW.Description;
        _view.alphaWS.Image = LatexUtils.CreateImageFromLatex(alphaW.LatexSymbol);
        _view.alphaWF.Image = LatexUtils.CreateImageFromLatex(alphaW.LatexFormula);
        var alphaWMBinding = new Binding("Text", alphaW, "Value");
        alphaWMBinding.Format += DoubleToString;
        _view.alphaWM.DataBindings.Add(alphaWMBinding);
        var alphaWIBinding = new Binding("Text", alphaW, "AltStringValue");
        _view.alphaWI.DataBindings.Add(alphaWIBinding);

        
        _view.invAlphaL.Text = invAlpha.Description;
        _view.invAlphaS.Image = LatexUtils.CreateImageFromLatex(invAlpha.LatexSymbol);
        _view.invAlphaF.Image = LatexUtils.CreateImageFromLatex(invAlpha.LatexFormula);
        var invAlphaMBinding = new Binding("Text", invAlpha, "Value");
        invAlphaMBinding.Format += DoubleTo6DecString;
        _view.invAlphaM.DataBindings.Add(invAlphaMBinding);
        var invAlphaIBinding = new Binding("Text", invAlpha, "Value");
        invAlphaIBinding.Format += DoubleTo6DecString;
        _view.invAlphaI.DataBindings.Add(invAlphaIBinding);

        
        _view.invAlphaWL.Text = invAlphaW.Description;
        _view.invAlphaWS.Image = LatexUtils.CreateImageFromLatex(invAlphaW.LatexSymbol);
        _view.invAlphaWF.Image = LatexUtils.CreateImageFromLatex(invAlphaW.LatexFormula);
        var invAlphaWMBinding = new Binding("Text", invAlphaW, "Value");
        invAlphaWMBinding.Format += DoubleTo6DecString;
        _view.invAlphaWM.DataBindings.Add(invAlphaWMBinding);
        var invAlphaWIBinding = new Binding("Text", invAlphaW, "Value");
        invAlphaWIBinding.Format += DoubleTo6DecString;
        _view.invAlphaWI.DataBindings.Add(invAlphaWIBinding);

        
        _view.yL.Text = y.Description;
        _view.yS.Image = LatexUtils.CreateImageFromLatex(y.LatexSymbol);
        _view.yF.Image = LatexUtils.CreateImageFromLatex(y.LatexFormula);
        var yMBinding = new Binding("Text", y, "Value");
        yMBinding.Format += DoubleTo6DecString;
        _view.yM.DataBindings.Add(yMBinding);
        var yIBinding = new Binding("Text", y, "Value");
        yIBinding.Format += DoubleTo6DecString;
        _view.yI.DataBindings.Add(yIBinding);

        
        _view.sumXL.Text = sigmaX.Description;
        _view.sumXS.Image = LatexUtils.CreateImageFromLatex(sigmaX.LatexSymbol);
        _view.sumXF.Image = LatexUtils.CreateImageFromLatex(sigmaX.LatexFormula);
        var sumXMBinding = new Binding("Text", sigmaX, "Value");
        sumXMBinding.Format += DoubleTo6DecString;
        _view.sumXM.DataBindings.Add(sumXMBinding);
        var sumXIBinding = new Binding("Text", sigmaX, "Value");
        sumXIBinding.Format += DoubleTo6DecString;
        _view.sumXI.DataBindings.Add(sumXIBinding);

        _view.dL.Text = d1.Description;
        _view.d1S.Image = LatexUtils.CreateImageFromLatex(d1.LatexSymbol);
        _view.d1F.Image = LatexUtils.CreateImageFromLatex(d1.LatexFormula);
        var d1MBinding = new Binding("Text", d1, "Value");
        d1MBinding.Format += DoubleTo6DecString;
        _view.d1M.DataBindings.Add(d1MBinding);
        var d1IBinding = new Binding("Text", d1, "ImperialValue");
        d1IBinding.Format += DoubleTo6DecString;
        _view.d1I.DataBindings.Add(d1IBinding); 
        
        _view.d2S.Image = LatexUtils.CreateImageFromLatex(d2.LatexSymbol);
        _view.d2F.Image = LatexUtils.CreateImageFromLatex(d2.LatexFormula);
        var d2MBinding = new Binding("Text", d2, "Value");
        d2MBinding.Format += DoubleTo6DecString;
        _view.d2M.DataBindings.Add(d2MBinding);
        var d2IBinding = new Binding("Text", d2, "ImperialValue");
        d2IBinding.Format += DoubleTo6DecString;
        _view.d2I.DataBindings.Add(d2IBinding); 
        
        _view.dbL.Text = db1.Description;
        _view.db1S.Image = LatexUtils.CreateImageFromLatex(db1.LatexSymbol);
        _view.db1F.Image = LatexUtils.CreateImageFromLatex(db1.LatexFormula);
        var db1MBinding = new Binding("Text", db1, "Value");
        db1MBinding.Format += DoubleTo6DecString;
        _view.db1M.DataBindings.Add(db1MBinding);
        var db1IBinding = new Binding("Text", db1, "ImperialValue");
        db1IBinding.Format += DoubleTo6DecString;
        _view.db1I.DataBindings.Add(db1IBinding); 
        
        _view.db2S.Image = LatexUtils.CreateImageFromLatex(db2.LatexSymbol);
        _view.db2F.Image = LatexUtils.CreateImageFromLatex(db2.LatexFormula);
        var db2MBinding = new Binding("Text", db2, "Value");
        db2MBinding.Format += DoubleTo6DecString;
        _view.db2M.DataBindings.Add(db2MBinding);
        var db2IBinding = new Binding("Text", db2, "ImperialValue");
        db2IBinding.Format += DoubleTo6DecString;
        _view.db2I.DataBindings.Add(db2IBinding); 
        
        _view.dwL.Text = dw1.Description;
        _view.dw1S.Image = LatexUtils.CreateImageFromLatex(dw1.LatexSymbol);
        _view.dw1F.Image = LatexUtils.CreateImageFromLatex(dw1.LatexFormula);
        var dw1MBinding = new Binding("Text", dw1, "Value");
        dw1MBinding.Format += DoubleTo6DecString;
        _view.dw1M.DataBindings.Add(dw1MBinding);
        var dw1IBinding = new Binding("Text", dw1, "ImperialValue");
        dw1IBinding.Format += DoubleTo6DecString;
        _view.dw1I.DataBindings.Add(dw1IBinding); 
        
        _view.dw2S.Image = LatexUtils.CreateImageFromLatex(dw2.LatexSymbol);
        _view.dw2F.Image = LatexUtils.CreateImageFromLatex(dw2.LatexFormula);
        var dw2MBinding = new Binding("Text", dw2, "Value");
        dw2MBinding.Format += DoubleTo6DecString;
        _view.dw2M.DataBindings.Add(dw2MBinding);
        var dw2IBinding = new Binding("Text", dw2, "ImperialValue");
        dw2IBinding.Format += DoubleTo6DecString;
        _view.dw2I.DataBindings.Add(dw2IBinding); 
        
        _view.hfL.Text = hf1.Description;
        _view.hf1S.Image = LatexUtils.CreateImageFromLatex(hf1.LatexSymbol);
        _view.hf1F.Image = LatexUtils.CreateImageFromLatex(hf1.LatexFormula);
        var hf1MBinding = new Binding("Text", hf1, "Value");
        hf1MBinding.Format += DoubleTo6DecString;
        _view.hf1M.DataBindings.Add(hf1MBinding);
        var hf1IBinding = new Binding("Text", hf1, "ImperialValue");
        hf1IBinding.Format += DoubleTo6DecString;
        _view.hf1I.DataBindings.Add(hf1IBinding); 
        
        _view.hf2S.Image = LatexUtils.CreateImageFromLatex(hf2.LatexSymbol);
        _view.hf2F.Image = LatexUtils.CreateImageFromLatex(hf2.LatexFormula);
        var hf2MBinding = new Binding("Text", hf2, "Value");
        hf2MBinding.Format += DoubleTo6DecString;
        _view.hf2M.DataBindings.Add(hf2MBinding);
        var hf2IBinding = new Binding("Text", hf2, "ImperialValue");
        hf2IBinding.Format += DoubleTo6DecString;
        _view.hf2I.DataBindings.Add(hf2IBinding);
        
        _view.haL.Text = ha1.Description;
        _view.ha1S.Image = LatexUtils.CreateImageFromLatex(ha1.LatexSymbol);
        _view.ha1F.Image = LatexUtils.CreateImageFromLatex(ha1.LatexFormula);
        var ha1MBinding = new Binding("Text", ha1, "Value");
        ha1MBinding.Format += DoubleTo6DecString;
        _view.ha1M.DataBindings.Add(ha1MBinding);
        var ha1IBinding = new Binding("Text", ha1, "ImperialValue");
        ha1IBinding.Format += DoubleTo6DecString;
        _view.ha1I.DataBindings.Add(ha1IBinding); 
        
        _view.ha2S.Image = LatexUtils.CreateImageFromLatex(ha2.LatexSymbol);
        _view.ha2F.Image = LatexUtils.CreateImageFromLatex(ha2.LatexFormula);
        var ha2MBinding = new Binding("Text", ha2, "Value");
        ha2MBinding.Format += DoubleTo6DecString;
        _view.ha2M.DataBindings.Add(ha2MBinding);
        var ha2IBinding = new Binding("Text", ha2, "ImperialValue");
        ha2IBinding.Format += DoubleTo6DecString;
        _view.ha2I.DataBindings.Add(ha2IBinding);
        
        _view.hL.Text = h.Description;
        _view.hS.Image = LatexUtils.CreateImageFromLatex(h.LatexSymbol);
        _view.hF.Image = LatexUtils.CreateImageFromLatex(h.LatexFormula);
        var hMBinding = new Binding("Text", h, "Value");
        hMBinding.Format += DoubleTo6DecString;
        _view.hM.DataBindings.Add(hMBinding);
        var hIBinding = new Binding("Text", h, "ImperialValue");
        hIBinding.Format += DoubleTo6DecString;
        _view.hI.DataBindings.Add(hIBinding); 
        
        _view.daL.Text = da1.Description;
        _view.da1S.Image = LatexUtils.CreateImageFromLatex(da1.LatexSymbol);
        _view.da1F.Image = LatexUtils.CreateImageFromLatex(da1.LatexFormula);
        var da1MBinding = new Binding("Text", da1, "Value");
        da1MBinding.Format += DoubleTo6DecString;
        _view.da1M.DataBindings.Add(da1MBinding);
        var da1IBinding = new Binding("Text", da1, "ImperialValue");
        da1IBinding.Format += DoubleTo6DecString;
        _view.da1I.DataBindings.Add(da1IBinding); 
        
        _view.da2S.Image = LatexUtils.CreateImageFromLatex(da2.LatexSymbol);
        _view.da2F.Image = LatexUtils.CreateImageFromLatex(da2.LatexFormula);
        var da2MBinding = new Binding("Text", da2, "Value");
        da2MBinding.Format += DoubleTo6DecString;
        _view.da2M.DataBindings.Add(da2MBinding);
        var da2IBinding = new Binding("Text", da2, "ImperialValue");
        da2IBinding.Format += DoubleTo6DecString;
        _view.da2I.DataBindings.Add(da2IBinding);
        
        _view.dfL.Text = df1.Description;
        _view.df1S.Image = LatexUtils.CreateImageFromLatex(df1.LatexSymbol);
        _view.df1F.Image = LatexUtils.CreateImageFromLatex(df1.LatexFormula);
        var df1MBinding = new Binding("Text", df1, "Value");
        df1MBinding.Format += DoubleTo6DecString;
        _view.df1M.DataBindings.Add(df1MBinding);
        var df1IBinding = new Binding("Text", df1, "ImperialValue");
        df1IBinding.Format += DoubleTo6DecString;
        _view.df1I.DataBindings.Add(df1IBinding); 
        
        _view.df2S.Image = LatexUtils.CreateImageFromLatex(df2.LatexSymbol);
        _view.df2F.Image = LatexUtils.CreateImageFromLatex(df2.LatexFormula);
        var df2MBinding = new Binding("Text", df2, "Value");
        df2MBinding.Format += DoubleTo6DecString;
        _view.df2M.DataBindings.Add(df2MBinding);
        var df2IBinding = new Binding("Text", df2, "ImperialValue");
        df2IBinding.Format += DoubleTo6DecString;
        _view.df2I.DataBindings.Add(df2IBinding);

        _view.egL.Text = eg.Description;
        _view.egS.Image =   LatexUtils.CreateImageFromLatex(eg.LatexSymbol);
        _view.egF.Image =   LatexUtils.CreateImageFromLatex(eg.LatexFormula);
        var egMBinding = new Binding("Text", eg, "Value");
        egMBinding.Format += DoubleTo6DecString;
        _view.egM.DataBindings.Add(egMBinding);
        var egIBinding = new Binding("Text", eg, "Value");
        egIBinding.Format += DoubleTo6DecString;
        _view.egI.DataBindings.Add(egIBinding);
    }

    private void InitParameters()
    {
        module = _model.Gear.Module;
        alpha = _model.Gear.PressureAngle;
        z1 = _model.Gear.TeethPinion;
        z2 = _model.Gear.TeethWheel;
        x2 = _model.Gear.CoefficientProfileShiftWheel;
        x1 = _model.Gear.CoefficientProfileShiftPinion;
        ax = _model.Gear.WorkingCentreDistance;
        alphaW = _model.Gear.WorkingPressureAngle;
        invAlpha = _model.Gear.InvoluteFunction;
        invAlphaW = _model.Gear.WorkingInvoluteFunction;
        y = _model.Gear.CentreDistanceIncrementFactor;
        sigmaX = _model.Gear.SumCoefficientProfileShift;
        d1 = _model.Gear.PitchDiameterPinion;
        d2 = _model.Gear.PitchDiameterWheel;
        db1 = _model.Gear.BaseDiameterPinion;
        db2 = _model.Gear.BaseDiameterWheel;
        dw1 = _model.Gear.WorkingPitchDiameterPinion;
        dw2 = _model.Gear.WorkingPitchDiameterWheel;
        ha1 = _model.Gear.AddendumPinion;
        ha2 = _model.Gear.AddendumWheel;
        hf1 = _model.Gear.DedendumPinion;
        hf2 = _model.Gear.DedendumWheel;
        h = _model.Gear.WholeDepth;
        da1 = _model.Gear.OutsideDiameterPinion;
        da2 = _model.Gear.OutsideDiameterWheel;
        df1 = _model.Gear.RootDiameterPinion;
        df2 = _model.Gear.RootDiameterWheel;
        eg = _model.Gear.TotalContactRatio;
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