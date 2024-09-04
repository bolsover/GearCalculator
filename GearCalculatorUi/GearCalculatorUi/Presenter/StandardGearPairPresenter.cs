using System;
using System.Windows.Forms;
using Bolsover.GearCalculator.Parameters;
using Bolsover.GearCalculatorUi.Model;
using Bolsover.GearCalculatorUi.Utils;
using Bolsover.GearCalculatorUi.View;


namespace Bolsover.GearCalculatorUi.Presenter;

public class StandardGearPairPresenter
{
    private readonly StandardGearPairView _view;
    private StandardGearPairModel _model;

    public StandardGearPairPresenter(StandardGearPairView view)
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

    private void DoubleToIntString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0");
    }

    private void DoubleToMMString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 mm");
     
    }

    private void DoubleToDegString(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000°");
      
    }

    private void DoubleToImperialModule(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in  D.P.");
      
    }

    private void DoubleToImperial(object sender, ConvertEventArgs cevent)
    {
        ConvertDoubleToString(sender, cevent, "0.000 in");
      
    }
    
    // private void UpdateGearDetails(GearParameter gearPart, Label label, Label symbolImage, Label formulaImage, TextBox textBox, TextBox imperialTextBox)
    // {
    //    
    //         if (label != null) label.Text = gearPart.Description;
    //    
    //     symbolImage.Image = LatexUtils.CreateImageFromLatex(gearPart.LatexSymbol);
    //     formulaImage.Image = LatexUtils.CreateImageFromLatex(gearPart.LatexFormula);
    //
    //     var binding = new Binding("Text", gearPart, "Value");
    //     binding.Format += DoubleToMMString;
    //     textBox.DataBindings.Add(binding);
    //
    //     var imperialBinding = new Binding("Text", gearPart, "ImperialValue");
    //     imperialBinding.Format += DoubleToImperial;
    //     imperialTextBox.DataBindings.Add(imperialBinding);
    // }
    
    private void UpdateGearDetails(GearParameter gearPart, Label label, PictureBox symbolImage, PictureBox formulaImage, TextBox textBox, TextBox imperialTextBox)
    {
       
        if (label != null) label.Text = gearPart.Description;
       
        symbolImage.Image = LatexUtils.CreateImageFromLatex(gearPart.LatexSymbol);
        formulaImage.Image = LatexUtils.CreateImageFromLatex(gearPart.LatexFormula);

        var binding = new Binding("Text", gearPart, "Value");
        binding.Format += DoubleToMMString;
        textBox.DataBindings.Add(binding);

        var imperialBinding = new Binding("Text", gearPart, "ImperialValue");
        imperialBinding.Format += DoubleToImperial;
        imperialTextBox.DataBindings.Add(imperialBinding);
    }

    private void Init()
    {
        _model = new StandardGearPairModel();
        var module = _model.Gear.Module;
        _view.moduleNumericUpDown.Value = (decimal)module.Value;
        _view.moduleLabel.Text = module.Description;
        _view.moduleSymbol.Image = LatexUtils.CreateImageFromLatex(module.LatexSymbol);
        var moduleImperialBinding = new Binding("Text", module, "ImperialValue");
        moduleImperialBinding.Format += DoubleToImperialModule;
        _view.moduleImperial.DataBindings.Add(moduleImperialBinding);

        var teethPinion = _model.Gear.TeethPinion;
        _view.teethPinionNumericUpDown.Value = (decimal)teethPinion.Value;
        _view.teethPinionLabel.Text = teethPinion.Description;
        _view.teethPinionSymbol.Image = LatexUtils.CreateImageFromLatex(teethPinion.LatexSymbol);
        var teethPinionImperialBinding = new Binding("Text", teethPinion, "Value");
        teethPinionImperialBinding.Format += DoubleToIntString;
        _view.teethPinionImperial.DataBindings.Add(teethPinionImperialBinding);
        
        var teethWheel = _model.Gear.TeethWheel;
        _view.teethWheelNumericUpDown.Value = (decimal)teethWheel.Value;
       // _view.teethPinionLabel.Text = teethPinion.Description;
        _view.teethWheelSymbol.Image = LatexUtils.CreateImageFromLatex(teethWheel.LatexSymbol);
        var teethWheelImperialBinding = new Binding("Text", teethWheel, "Value");
        teethWheelImperialBinding.Format += DoubleToIntString;
        _view.teethWheelImperial.DataBindings.Add(teethWheelImperialBinding);

        var pressureAngle = _model.Gear.PressureAngle;
        _view.pressureAngleNumericUpDown.Value = (decimal)pressureAngle.Value;
        _view.pressureAngleLabel.Text = pressureAngle.Description;
        _view.pressureAngleSymbol.Image = LatexUtils.CreateImageFromLatex(pressureAngle.LatexSymbol);
        var pressureAngleImperialBinding = new Binding("Text", pressureAngle, "AltStringValue");
       // pressureAngleImperialBinding.Format += DoubleToDegString;
        _view.pressureAngleImperial.DataBindings.Add(pressureAngleImperialBinding);


        UpdateGearDetails(_model.Gear.PitchDiameterPinion, _view.pitchDiameterPinionLabel,
            _view.pitchDiameterPinionSymbol,
            _view.pitchDiameterPinionFormula, _view.pitchDiameterPinionTextBox, _view.pitchDiameterPinionImperial);
        
        UpdateGearDetails(_model.Gear.PitchDiameterWheel, null,
            _view.pitchDiameterWheelSymbol,
            _view.pitchDiameterWheelFormula, _view.pitchDiameterWheelTextBox, _view.pitchDiameterWheelImperial);
        
        UpdateGearDetails(_model.Gear.BaseDiameterPinion, _view.baseDiameterPinionLabel,
            _view.baseDiameterPinionSymbol,
            _view.baseDiameterPinionFormula, _view.baseDiameterPinionTextBox, _view.baseDiameterPinionImperial);
        
        UpdateGearDetails(_model.Gear.BaseDiameterWheel, null,
            _view.baseDiameterWheelSymbol,
            _view.baseDiameterWheelFormula, _view.baseDiameterWheelTextBox, _view.baseDiameterWheelImperial);
        
        UpdateGearDetails(_model.Gear.Addendum, _view.addendumLabel,
            _view.addendumSymbol,
            _view.addendumFormula, _view.addendumTextBox, _view.addendumImperial);
        
        UpdateGearDetails(_model.Gear.Dedendum, _view.dedendumLabel,
            _view.dedendumSymbol,
            _view.dedendumFormula, _view.dedendumTextBox, _view.dedendumImperial);
        
        UpdateGearDetails(_model.Gear.OutsideDiameterPinion, _view.outsideDiameterPinionLabel,
            _view.outsideDiameterPinionSymbol,
            _view.outsideDiameterPinionFormula, _view.outsideDiameterPinionTextBox, _view.outsideDiameterPinionImperial);
        
        UpdateGearDetails(_model.Gear.OutsideDiameterWheel, null,
            _view.outsideDiameterWheelSymbol,
            _view.outsideDiameterWheelFormula, _view.outsideDiameterWheelTextBox, _view.outsideDiameterWheelImperial);
        
        UpdateGearDetails(_model.Gear.RootDiameterPinion, _view.rootDiameterPinionLabel,
            _view.rootDiameterPinionSymbol,
            _view.rootDiameterPinionFormula, _view.rootDiameterPinionTextBox, _view.rootDiameterPinionImperial);
        
        UpdateGearDetails(_model.Gear.RootDiameterWheel, null,
            _view.rootDiameterWheelSymbol,
            _view.rootDiameterWheelFormula, _view.rootDiameterWheelTextBox, _view.rootDiameterWheelImperial);
       
        UpdateGearDetails(_model.Gear.StandardCentreDistance, _view.standardCentreDistanceLabel,
            _view.standardCentreDistanceSymbol,
            _view.standardCentreDistanceFormula, _view.standardCentreDistanceMetric, _view.standardCentreDistanceImperial);

        _model.Gear.Calculate();
    }

    private void SetupEventListeners()
    {
        _view.EditModuleEvent += ViewOnEditModuleEvent;
        _view.EditTeethPinionEvent += ViewOnEditTeethPinionEvent;
        _view.EditTeethWheelEvent += ViewOnEditTeethWheelEvent;
        _view.EditPressureAngleEvent += ViewOnEditPressureAngleEvent;
    }


    private void ViewOnEditModuleEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.Module.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditTeethPinionEvent(object sender, EventArgs e)
    {
        _model.Gear.Calculate();
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.TeethPinion.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditTeethWheelEvent(object sender, EventArgs e)
    {
        _model.Gear.Calculate();
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.TeethWheel.Value = newValue;
        }

        _model.Gear.Calculate();
    }

    private void ViewOnEditPressureAngleEvent(object sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.PressureAngle.Value = newValue;
        }

        _model.Gear.Calculate();
    }
}