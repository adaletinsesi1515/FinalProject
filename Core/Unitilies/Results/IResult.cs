using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    //temel voidler için başlangıç 
    public interface IResult
    {
        //get sadece okunabilir
        //set sadece yazılabilir
        bool Success { get; }
        string Message { get; }

    }
}
