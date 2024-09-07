using Bolsover.GearCalculatorUi.Model;
using Bolsover.GearCalculatorUi.View;
using System.Windows.Forms;
using System;
using Bolsover.GearCalculator.Gear;
using Bolsover.GearCalculator.Parameters;
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
    private ProfileShiftExtPair gear;
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
    private AutoCalcMode autoCalcMode;

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


    private void DoubleToImperial(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in");
    }

    void SetViewAttributes(Control label, PictureBox symbolImage, PictureBox formulaImage, GearParameter gearParameter)
    {
        label.Text = gearParameter.Description;
        symbolImage.Image = LatexUtils.CreateImageFromLatex(gearParameter.LatexSymbol);
        formulaImage.Image = LatexUtils.CreateImageFromLatex(gearParameter.LatexFormula);
    }

    void AddBinding(Control control, string propertyName, object dataSource, string dataMember,
        ConvertEventHandler formatHandler = null)
    {
        var binding = new Binding(propertyName, dataSource, dataMember);
        if (formatHandler != null)
        {
            binding.Format += formatHandler;
        }

        control.DataBindings.Add(binding);
    }

    private void Init()
    {
        _model = new ProfileShiftExtPairModel();
        InitParameters();
        gear.Calculate();

        //module
        _view.mUD.Value = (decimal)module.Value;
        _view.mL.Text = module.Description;
        _view.mN.Text = module.Notes;
        _view.mS.Image = LatexUtils.CreateImageFromLatex(module.LatexSymbol);
        AddBinding(_view.mDP, "Text", module, "ImperialValue", DoubleToDiametralPitch);
        AddBinding(_view.mCP, "Text", module, "AltValue", DoubleToCircularPitch);

        // pressure angle
        _view.alphaUD.Value = (decimal)alpha.Value;
        _view.alphaL.Text = alpha.Description;
        _view.alphaS.Image = LatexUtils.CreateImageFromLatex(alpha.LatexSymbol);
        AddBinding(_view.alphaI, "Text", alpha, "AltStringValue");

        // pinion teeth
        _view.z1UD.Value = (decimal)z1.Value;
        _view.zL.Text = z1.Description;
        _view.z1S.Image = LatexUtils.CreateImageFromLatex(z1.LatexSymbol);
        AddBinding(_view.z1I, "Text", z1, "Value");

        // wheel teeth
        _view.z2UD.Value = (decimal)z2.Value;
        _view.z2S.Image = LatexUtils.CreateImageFromLatex(z2.LatexSymbol);
        AddBinding(_view.z2I, "Text", z2, "Value");

        // pinion coefficient of profile shift
        _view.x1UD.Value = (decimal)x1.Value;
        _view.xL.Text = x1.Description;
        _view.x1S.Image = LatexUtils.CreateImageFromLatex(x1.LatexSymbol);
        AddBinding(_view.x1I, "Text", x1, "Value", DoubleToString);

        // wheel coefficient of profile shift
        _view.x2UD.Value = (decimal)x2.Value;
        _view.x2S.Image = LatexUtils.CreateImageFromLatex(x2.LatexSymbol);
        AddBinding(_view.x2I, "Text", x2, "Value", DoubleToString);

         // working centre distance
        _view.axUD.Value = (decimal)ax.Value;
        _view.axL.Text = ax.Description;
        _view.axS.Image = LatexUtils.CreateImageFromLatex(ax.LatexSymbol);
        AddBinding(_view.axI, "Text", ax, "ImperialValue", DoubleToString);

        // working pressure angle
        SetViewAttributes(_view.alphaWL, _view.alphaWS, _view.alphaWF, alphaW);
        AddBinding(_view.alphaWM, "Text", alphaW, "Value", DoubleToString);
        AddBinding(_view.alphaWI, "Text", alphaW, "AltStringValue");

        // involute function
        SetViewAttributes(_view.invAlphaL, _view.invAlphaS, _view.invAlphaF, invAlpha);
        AddBinding(_view.invAlphaM, "Text", invAlpha, "Value", DoubleToString);
        AddBinding(_view.invAlphaI, "Text", invAlpha, "Value", DoubleToString);

        // working involute function
        SetViewAttributes(_view.invAlphaWL, _view.invAlphaWS, _view.invAlphaWF, invAlphaW);
        AddBinding(_view.invAlphaWM, "Text", invAlphaW, "Value", DoubleToString);
        AddBinding(_view.invAlphaWI, "Text", invAlphaW, "Value", DoubleToString);

        // centre distance increment factor
        SetViewAttributes(_view.yL, _view.yS, _view.yF, y);
        AddBinding(_view.yM, "Text", y, "Value", DoubleToString);
        AddBinding(_view.yI, "Text", y, "Value", DoubleToString);

        // sum coefficient of profile shift
        SetViewAttributes(_view.sumXL, _view.sumXS, _view.sumXF, sigmaX);
        AddBinding(_view.sumXM, "Text", sigmaX, "Value", DoubleToString);
        AddBinding(_view.sumXI, "Text", sigmaX, "Value", DoubleToString);

        // pinion pitch diameter
        SetViewAttributes(_view.dL, _view.d1S, _view.d1F, d1);
        AddBinding(_view.d1M, "Text", d1, "Value", DoubleToString);
        AddBinding(_view.d1I, "Text", d1, "ImperialValue", DoubleToString);

        // wheel pitch diameter
        SetViewAttributes(_view.dL, _view.d2S, _view.d2F, d2);
        AddBinding(_view.d2M, "Text", d2, "Value", DoubleToString);
        AddBinding(_view.d2I, "Text", d2, "ImperialValue", DoubleToString);

        // pinion base diameter
        SetViewAttributes(_view.dbL, _view.db1S, _view.db1F, db1);
        AddBinding(_view.db1M, "Text", db1, "Value", DoubleToString);
        AddBinding(_view.db1I, "Text", db1, "ImperialValue", DoubleToString);

        // wheel base diameter
        SetViewAttributes(_view.dbL, _view.db2S, _view.db2F, db2);
        AddBinding(_view.db2M, "Text", db2, "Value", DoubleToString);
        AddBinding(_view.db2I, "Text", db2, "ImperialValue", DoubleToString);


        // pinion working pitch diameter
        SetViewAttributes(_view.dwL, _view.dw1S, _view.dw1F, dw1);
        AddBinding(_view.dw1M, "Text", dw1, "Value", DoubleToString);
        AddBinding(_view.dw1I, "Text", dw1, "ImperialValue", DoubleToString);


        // wheel working pitch diameter
        SetViewAttributes(_view.dwL, _view.dw2S, _view.dw2F, dw2);
        AddBinding(_view.dw2M, "Text", dw2, "Value", DoubleToString);
        AddBinding(_view.dw2I, "Text", dw2, "ImperialValue", DoubleToString);


        // pinion dedendum
        SetViewAttributes(_view.hfL, _view.hf1S, _view.hf1F, hf1);
        AddBinding(_view.hf1M, "Text", hf1, "Value", DoubleToString);
        AddBinding(_view.hf1I, "Text", hf1, "ImperialValue", DoubleToString);


        // wheel dedendum
        SetViewAttributes(_view.hfL, _view.hf2S, _view.hf2F, hf2);
        AddBinding(_view.hf2M, "Text", hf2, "Value", DoubleToString);
        AddBinding(_view.hf2I, "Text", hf2, "ImperialValue", DoubleToString);


        // pinion addendum
        SetViewAttributes(_view.haL, _view.ha1S, _view.ha1F, ha1);
        AddBinding(_view.ha1M, "Text", ha1, "Value", DoubleToString);
        AddBinding(_view.ha1I, "Text", ha1, "ImperialValue", DoubleToString);


        // wheel addendum
        SetViewAttributes(_view.haL, _view.ha2S, _view.ha2F, ha2);
        AddBinding(_view.ha2M, "Text", ha2, "Value", DoubleToString);
        AddBinding(_view.ha2I, "Text", ha2, "ImperialValue", DoubleToString);


        // whole depth
        SetViewAttributes(_view.hL, _view.hS, _view.hF, h);
        AddBinding(_view.hM, "Text", h, "Value", DoubleToString);
        AddBinding(_view.hI, "Text", h, "ImperialValue", DoubleToString);


        // pinion outside diameter
        SetViewAttributes(_view.daL, _view.da1S, _view.da1F, da1);
        AddBinding(_view.da1M, "Text", da1, "Value", DoubleToString);
        AddBinding(_view.da1I, "Text", da1, "ImperialValue", DoubleToString);


        // wheel outside diameter
        SetViewAttributes(_view.daL, _view.da2S, _view.da2F, da2);
        AddBinding(_view.da2M, "Text", da2, "Value", DoubleToString);
        AddBinding(_view.da2I, "Text", da2, "ImperialValue", DoubleToString);


        // pinion root diameter
        SetViewAttributes(_view.dfL, _view.df1S, _view.df1F, df1);
        AddBinding(_view.df1M, "Text", df1, "Value", DoubleToString);
        AddBinding(_view.df1I, "Text", df1, "ImperialValue", DoubleToString);


        // wheel root diameter
        SetViewAttributes(_view.dfL, _view.df2S, _view.df2F, df2);
        AddBinding(_view.df2M, "Text", df2, "Value", DoubleToString);
        AddBinding(_view.df2I, "Text", df2, "ImperialValue", DoubleToString);


        // contact ratio
        SetViewAttributes(_view.egL, _view.egS, _view.egF, eg);
        AddBinding(_view.egM, "Text", eg, "Value", DoubleToString);
        AddBinding(_view.egI, "Text", eg, "Value", DoubleToString);
        
        // calculation mode
        _view.autoL.Text = autoCalcMode.Description;
        _view.autoN.Text = autoCalcMode.Notes;
    }

    private void InitParameters()
    {
        gear = _model.Gear;
        module = gear.Module;
        alpha = gear.PressureAngle;
        z1 = gear.TeethPinion;
        z2 = gear.TeethWheel;
        x2 = gear.CoefficientProfileShiftWheel;
        x1 = gear.CoefficientProfileShiftPinion;
        ax = gear.WorkingCentreDistance;
        autoCalcMode = gear.AutoCalcMode;
        alphaW = gear.WorkingPressureAngle;
        invAlpha = gear.InvoluteFunction;
        invAlphaW = gear.WorkingInvoluteFunction;
        y = gear.CentreDistanceIncrementFactor;
        sigmaX = gear.SumCoefficientProfileShift;
        d1 = gear.PitchDiameterPinion;
        d2 = gear.PitchDiameterWheel;
        db1 = gear.BaseDiameterPinion;
        db2 = gear.BaseDiameterWheel;
        dw1 = gear.WorkingPitchDiameterPinion;
        dw2 = gear.WorkingPitchDiameterWheel;
        ha1 = gear.AddendumPinion;
        ha2 = gear.AddendumWheel;
        hf1 = gear.DedendumPinion;
        hf2 = gear.DedendumWheel;
        h = gear.WholeDepth;
        da1 = gear.OutsideDiameterPinion;
        da2 = gear.OutsideDiameterWheel;
        df1 = gear.RootDiameterPinion;
        df2 = gear.RootDiameterWheel;
        eg = gear.TotalContactRatio;
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
        _view.AutoCalcModeEvent += ViewOnChangeAutoCalcMode;
    }

    private void ViewOnEditAxEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            ax.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditX2Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            x2.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditX1Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            x1.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditAlphaEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            alpha.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditZ2Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            z2.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditZ1Event(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            z1.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnEditMEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            module.Value = newValue;
        }

        gear.Calculate();
    }

    private void ViewOnChangeAutoCalcMode(object sender, EventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            var checkedValue = radioButton.Checked;
            autoCalcMode.Auto = checkedValue;
        }
    }
}