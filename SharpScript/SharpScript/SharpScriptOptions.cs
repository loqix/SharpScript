﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpScript
{
    public class SharpScriptOptions
    {
        public List<Assembly> ReferencedAssemblies { get; set; } = new List<Assembly>() {
            typeof(object).Assembly, // mscorlib
            typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException).Assembly, // Microsoft.CSharp
            typeof(Microsoft.CSharp.CSharpCodeProvider).Assembly, // System
            Assembly.GetAssembly(typeof(System.Dynamic.DynamicObject)),  // System.Core
        };
        public List<string> Imports { get; set; } = new List<string>();
    }
}
