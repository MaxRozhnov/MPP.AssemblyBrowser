using System;
using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public class NamespaceInf
    {
        public readonly string Name;
        public readonly List<TypeInf> Types;

        public NamespaceInf(string name)
        {
            Name = name;
            Types = new List<TypeInf>();
        }

        public void AddType(TypeInf typeInf)
        {
            Types.Add(typeInf);
        }
       
    }
}
