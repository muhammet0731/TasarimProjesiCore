﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mustİşlemler.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
  
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

    }
}
