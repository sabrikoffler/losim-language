﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * Simol C# Framework, v1.0, 20240106.
 * Limitations of C# framework for simol:
 * 
 * No 'nature' or 'contracts' attributes, nor possibility to have 'With_compat' on a local variable. All this is due
 * to C# attributes limitations.
 */
namespace Org.Simol.Framework.Csharp
{
    public enum Role
    {
        DESIGN_ROLE,
        GUI_ROLE,
        HUMAN_EXPERT,
        MACHINE_TOOL,
        UNDEFINED
    };

    [AttributeUsage(AttributeTargets.Class)]
    public class Simu_real_world_objAttribute: Attribute
    {
       
        private Role role;

        public Simu_real_world_objAttribute(Role theRole = Role.UNDEFINED)
        {
            this.role = theRole;
        }
    }
}
