using System;
using System.Windows.Forms;
using Bolsover.GearCalculatorUi.Model;
using Bolsover.GearCalculatorUi.View;
using static Bolsover.GearCalculatorUi.Utils.LatexUtils;


namespace Bolsover.GearCalculatorUi.Presenter;

public class SimpleGearPresenter
{
    private readonly SimpleGearView _view;
    private SimpleGearModel _model;

    public SimpleGearPresenter(SimpleGearView view)
    {
        _view = view;
        Init();
        SetupEventListeners();
    }

    private void DoubleToString(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0.000");
    }
    
    private void DoubleToIntString(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0");
    }
    
    private void DoubleToMMString(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0.000 mm");
    }
    
    private void DoubleToDegString(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0.000°");
    }
    
    private void DoubleToImperialModule(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0.000 in  DP");
    }
    
    private void DoubleToImperial(object sender, ConvertEventArgs cevent)
    {
        // The method converts only to string type. Test this using the DesiredType.
        if (cevent.DesiredType != typeof(string)) return;

        // Use the ToString method to format the value as currency ("c").
        cevent.Value = ((double)cevent.Value).ToString("0.000 in");
    }

    private void Init()
    {
        _model = new SimpleGearModel();
        var module = _model.Gear.Module;
        _view.moduleNumericUpDown.Value = (decimal)module.Value;
        _view.moduleLabel.Text = module.Description;
        _view.moduleSymbol.Image = CreateImageFromLatex(module.LatexSymbol);
        
        var moduleImperialBinding = new Binding("Text", module, "ImperialValue");
        moduleImperialBinding.Format += DoubleToImperialModule;
        _view.moduleImperial.DataBindings.Add(moduleImperialBinding);


        var teeth = _model.Gear.Teeth;
        _view.teethNumericUpDown.Value = (decimal)teeth.Value;
        _view.teethLabel.Text = teeth.Description;
        _view.teethSymbol.Image = CreateImageFromLatex(teeth.LatexSymbol);
        
        var teethImperialBinding = new Binding("Text", teeth, "Value");
        teethImperialBinding.Format += DoubleToIntString;
        _view.teethImperial.DataBindings.Add(teethImperialBinding);

        var pressureAngle = _model.Gear.PressureAngle;
        _view.pressureAngleNumericUpDown.Value = (decimal)pressureAngle.Value;
        _view.pressureAngleLabel.Text = pressureAngle.Description;
        _view.pressureAngleSymbol.Image = CreateImageFromLatex(pressureAngle.LatexSymbol);
        //_view.pressureAngleFormula.Image = LatexUtils.CreateImageFromLatex(pressureAngle.LatexFormula);
        
        // var pressureAngleBinding = new Binding("Text", pressureAngle, "Value");
        // pressureAngleBinding.Format += DoubleToDegString;
        // _view.pressureAngleImperial.DataBindings.Add(pressureAngleBinding);
        //
        var pressureAngleImperialBinding = new Binding("Text", pressureAngle, "Value");
        pressureAngleImperialBinding.Format += DoubleToDegString;
        _view.pressureAngleImperial.DataBindings.Add(pressureAngleImperialBinding);

        var pitchDiameter = _model.Gear.PitchDiameter;
        _view.pitchDiameterLabel.Text = pitchDiameter.Description;
        _view.pitchDiameterSymbol.Image = CreateImageFromLatex(pitchDiameter.LatexSymbol);
        _view.pitchDiameterFormula.Image = CreateImageFromLatex(pitchDiameter.LatexFormula);
        var pitchDiameterBinding = new Binding("Text", pitchDiameter, "Value");
        pitchDiameterBinding.Format += DoubleToMMString;
        _view.pitchDiameterTextBox.DataBindings.Add(pitchDiameterBinding);
        
        var pitchDiameterImperialBinding = new Binding("Text", pitchDiameter, "ImperialValue");
        pitchDiameterImperialBinding.Format += DoubleToImperial;
        _view.pitchDiameterImperial.DataBindings.Add(pitchDiameterImperialBinding);

        var baseDiameter = _model.Gear.BaseDiameter;
        _view.baseDiameterLabel.Text = baseDiameter.Description;
        _view.baseDiameterSymbol.Image = CreateImageFromLatex(baseDiameter.LatexSymbol);
        _view.baseDiameterFormula.Image = CreateImageFromLatex(baseDiameter.LatexFormula);
        var baseDiameterBinding = new Binding("Text", baseDiameter, "Value");
        baseDiameterBinding.Format += DoubleToMMString;
        _view.baseDiameterTextBox.DataBindings.Add(baseDiameterBinding);
        
        var baseDiameterImperialBinding = new Binding("Text", baseDiameter, "ImperialValue");
        baseDiameterImperialBinding.Format += DoubleToImperial;
        _view.baseDiameterImperial.DataBindings.Add(baseDiameterImperialBinding);
        
        
        var addendum = _model.Gear.Addendum;
        _view.addendumLabel.Text = addendum.Description;
        _view.addendumSymbol.Image = CreateImageFromLatex(addendum.LatexSymbol);
        _view.addendumFormula.Image = CreateImageFromLatex(addendum.LatexFormula);
        var addendumBinding = new Binding("Text", addendum, "Value");
        addendumBinding.Format += DoubleToMMString;
        _view.addendumTextBox.DataBindings.Add(addendumBinding);
        
        var addendumImperialBinding = new Binding("Text", addendum, "ImperialValue");
        addendumImperialBinding.Format += DoubleToImperial;
        _view.addendumImperial.DataBindings.Add(addendumImperialBinding);

        
        var dedendum = _model.Gear.Dedendum;
        _view.dedendumLabel.Text = dedendum.Description;
        _view.dedendumSymbol.Image = CreateImageFromLatex(dedendum.LatexSymbol);
        _view.dedendumFormula.Image = CreateImageFromLatex(dedendum.LatexFormula);
        var dedendumBinding = new Binding("Text", dedendum, "Value");
        dedendumBinding.Format += DoubleToMMString;
        _view.dedendumTextBox.DataBindings.Add(dedendumBinding);
        
        var dedendumImperialBinding = new Binding("Text", dedendum, "ImperialValue");
        dedendumImperialBinding.Format += DoubleToImperial;
        _view.dedendumImperial.DataBindings.Add(dedendumImperialBinding);

        
        var outsideDiameter = _model.Gear.OutsideDiameter;
        _view.outsideDiameterLabel.Text = outsideDiameter.Description;
        _view.outsideDiameterSymbol.Image = CreateImageFromLatex(outsideDiameter.LatexSymbol);
        _view.outsideDiameterFormula.Image = CreateImageFromLatex(outsideDiameter.LatexFormula);
        var outsideDiameterBinding = new Binding("Text", outsideDiameter, "Value");
        outsideDiameterBinding.Format += DoubleToMMString;
        _view.outsideDiameterTextBox.DataBindings.Add(outsideDiameterBinding);
        
        var outsideDiameterImperialBinding = new Binding("Text", outsideDiameter, "ImperialValue");
        outsideDiameterImperialBinding.Format += DoubleToImperial;
        _view.outsideDiameterImperial.DataBindings.Add(outsideDiameterImperialBinding);

        
        var rootDiameter = _model.Gear.RootDiameter;
        _view.rootDiameterLabel.Text = rootDiameter.Description;
        _view.rootDiameterSymbol.Image = CreateImageFromLatex(rootDiameter.LatexSymbol);
        _view.rootDiameterFormula.Image = CreateImageFromLatex(rootDiameter.LatexFormula);
        var rootDiameterBinding = new Binding("Text", rootDiameter, "Value");
        rootDiameterBinding.Format += DoubleToMMString;
        _view.rootDiameterTextBox.DataBindings.Add(rootDiameterBinding);
        
        var rootDiameterImperialBinding = new Binding("Text", rootDiameter, "ImperialValue");
        rootDiameterImperialBinding.Format += DoubleToImperial;
        _view.rootDiameterImperial.DataBindings.Add(rootDiameterImperialBinding);



        _model.Gear.Calculate();
    }

    private void SetupEventListeners()
    {
        _view.EditModuleEvent += ViewOnEditModuleEvent;
        _view.EditTeethEvent += ViewOnEditTeethEvent;
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

    private void ViewOnEditTeethEvent(object sender, EventArgs e)
    {
        _model.Gear.Calculate();
        if (sender is NumericUpDown numericUpDown)
        {
            var newValue = (double)numericUpDown.Value;
            _model.Gear.Teeth.Value = newValue;
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