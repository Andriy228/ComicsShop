﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Exceptions
{
    public class TagException : Exception
    {
        public TagException(string Message) :base(Message) {}
    }
}
