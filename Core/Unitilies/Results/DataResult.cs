using Core.Unitilies.Results;
using System.Collections.Generic;

namespace Core.Unitilies.Results
{
    internal class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}