using System;
using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public class NamespaceInf
    {
        public readonly string Name;
        public readonly List<TypeInfo> Types;

        public NamespaceInf(string name)
        {
            Name = name;
            Types = new List<TypeInfo>();
        }

        public void AddType(TypeInfo typeInfo)
        {
            Types.Add(typeInfo);
        }
       
    }
}
