using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bolsover.GearCalculator.Parameters;

namespace Bolsover.GearCalculator.Dictionary;

public class GearDataDictionary : Dictionary<GearParameterName, IGearParameter>
{
    public GearDataDictionary(List<GearParameterName> parameterNames)
    {
        foreach (var parameterName in parameterNames) this[parameterName] = GearParameterFactory.Create(parameterName);
    }

    public IGearParameter RetrieveByName(GearParameterName name)
    {
        IGearParameter gearParameter;
        if (TryGetValue(name, out gearParameter)) return gearParameter;

        throw new MissingParameterException("Parameter " + name + " is missing from dictionary");
    }

    public void Value(GearParameterName name, double value)
    {
        RetrieveByName(name).Value = value;
    }
}

public static class GearParameterFactory
{
    public static IGearParameter Create(GearParameterName parameterName)
    {
        var type = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(t => t.Name.Equals(parameterName.ToString(), StringComparison.Ordinal));
        if (type != null)
            return Activator.CreateInstance(type) as IGearParameter;
        throw new InvalidOperationException($"Cannot find the class named {parameterName.ToString()}");
    }
}