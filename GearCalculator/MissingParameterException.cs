using System;

namespace Bolsover.GearCalculator;

public class MissingParameterException : Exception
{
    public MissingParameterException()
    {
    }

    public MissingParameterException(string message) : base(message)
    {
    }

    public MissingParameterException(string message, Exception innerException) : base(message, innerException)
    {
    }
}