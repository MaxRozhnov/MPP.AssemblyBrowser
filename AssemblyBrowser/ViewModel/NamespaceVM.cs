using System;
using System.Collections.Generic;
using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class NamespaceVM
    {
        private NamespaceInf _namespace;

        public string Name
        {
            get { return _namespace.Name; }
        }

        public List<TypeVM> Types
        {
            get
            {
                var typesList = new List<TypeVM>();
                foreach (var type in _namespace.Types)
                {
                    typesList.Add(new TypeVM(type));
                }

                return typesList;
            }
        }

        public NamespaceVM(NamespaceInf namespaceInf)
        {
            _namespace = namespaceInf;
        }
    }
}