﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string messages) : base(success, messages)
        {

        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
