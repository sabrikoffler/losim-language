﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAttrsAvecConsole
{
    [AttributeUsage(AttributeTargets.Method)]
    class UnderstAttribute: Attribute
    {
    }
}
