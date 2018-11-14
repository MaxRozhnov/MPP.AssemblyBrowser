using System.Collections.Generic;
using System.Reflection;

namespace AssemblyBrowserLib
{
    public class AssemblyBrowser
    {
        
        public List<NamespaceInfo> GetAssemblyInfo(Assembly assembly)
        {
            var namespaces = new List<NamespaceInfo>();
            foreach (var type in assembly.DefinedTypes)
            {
                if (type.Namespace != null)
                {
                    var targetNamespace = namespaces.Find(x => x.Name == type.Namespace);
                    if (targetNamespace == null)
                    {
                        targetNamespace = new NamespaceInfo(type.Namespace);
                        targetNamespace.AddType(new TypeInfo(type));
                        namespaces.Add(targetNamespace);
                    }
                    else
                    {
                        targetNamespace.AddType(new TypeInfo(type));
                    }  
                }
                else
                {
                    var targetNamespace = namespaces.Find(x => x.Name == "Global");
                    if (targetNamespace == null)
                    {
                        targetNamespace = new NamespaceInfo("Global");
                        targetNamespace.AddType(new TypeInfo(type));
                        namespaces.Add(targetNamespace);
                    }
                    else
                    {
                        targetNamespace.AddType(new TypeInfo(type));
                    }  
                }
                
            }

            return namespaces;
        }
    }
}