using System;
using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public class NamespaceInfo
    {
        public readonly string Name;
        public readonly List<TypeInfo> Types;

        public NamespaceInfo(string name)
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
