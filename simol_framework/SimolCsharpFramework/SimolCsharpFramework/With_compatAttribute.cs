﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Simol.Framework.Csharp
{
    /**
     * We can not apply it on a local variable, because of C# limitation on attributes.
     */
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter)]
    class With_compatAttribute: Attribute
    {
    }
}
