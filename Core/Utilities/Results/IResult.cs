using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Begining for basic voids
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
