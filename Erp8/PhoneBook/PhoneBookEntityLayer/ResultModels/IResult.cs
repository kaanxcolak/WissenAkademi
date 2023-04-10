﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookEntityLayer.ResultModels
{
    public interface IResult
    {
        bool isSuccess { get; set; }
        string Message { get; set; }    
    }
}
