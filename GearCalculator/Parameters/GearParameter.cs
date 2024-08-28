using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters;

public class GearParameter : INotifyPropertyChanged
{
    private double _value;
    private double _imperialValue;
    private double _altValue;
    private string _altStringValue = "";
    private string _notes = "";

    public GearParameterName ParameterName { get; set; }
    public string Description { get; set; }

    public double Value
    {
        get => _value;
        set => SetField(ref _value, value);
    }
    
    public double ImperialValue
    {
        get => _imperialValue;
        set => SetField(ref _imperialValue, value);
    }

    public double AltValue
    {
        get => _altValue;
        set => SetField(ref _altValue, value);
    }
    
    public string AltStringValue
    {
        get => _altStringValue;
        set => SetField(ref _altStringValue, value);
    }
    
    public string Notes
    {
        get => _notes;
        set => SetField(ref _notes, value);
    }

    public string LatexSymbol { get; set; }
    public string LatexFormula { get; set; }

    public readonly Func<double, double> CalcImperial = (value) => value / 25.4;


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}