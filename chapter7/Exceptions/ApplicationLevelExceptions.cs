using System;

namespace Exceptions;

public class CarIsDeadException : ApplicationException
{
    public string Message { get; set; }
    public CarIsDeadException(string message) : base(message)
    {
    }
}
