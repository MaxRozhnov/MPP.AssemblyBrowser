using System.Collections.Generic;
using System.Reflection;

namespace AssemblyBrowserLib
{
    public class AssemblyBrowser
    {
        
        public List<NamespaceInf> GetAssemblyInfo(Assembly assembly)
        {
            var namespaces = new List<NamespaceInf>();
            foreach (var type in assembly.DefinedTypes)
            {
                if (type.Namespace != null)
                {
                    var targetNamespace = namespaces.Find(x => x.Name == type.Namespace);
                    if (targetNamespace == null)
                    {
                        targetNamespace = new NamespaceInf(type.Namespace);
                        targetNamespace.AddType(new TypeInf(type));
                        namespaces.Add(targetNamespace);
                    }
                    else
                    {
                        targetNamespace.AddType(new TypeInf(type));
                    }  
                }
                else
                {
                    var targetNamespace = namespaces.Find(x => x.Name == "Global");
                    if (targetNamespace == null)
                    {
                        targetNamespace = new NamespaceInf("Global");
                        targetNamespace.AddType(new TypeInf(type));
                        namespaces.Add(targetNamespace);
                    }
                    else
                    {
                        targetNamespace.AddType(new TypeInf(type));
                    }  
                }   
            }
            return namespaces;
        }
    }
}