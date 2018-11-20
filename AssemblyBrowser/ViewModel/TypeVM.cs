using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class TypeVM
    {
        private readonly TypeInf _type;

        public string TypeStringRepresentation
        {
            get
            {
                var stringRepresentation = "";
                if (_type.IsPublic)
                {
                    stringRepresentation += "public ";
                }
                if (_type.IsSealed)
                {
                    stringRepresentation += "sealed ";
                }
                if (_type.IsInterface)
                {
                    stringRepresentation += "interface ";
                }
                if (_type.IsAbstract && !_type.IsInterface)
                {
                    stringRepresentation += "abstract ";
                }
                if (_type.IsClass)
                {
                    stringRepresentation += "class ";
                }

                stringRepresentation += _type.Name;
                return stringRepresentation;
            }
        }

        public IEnumerable<object> Members
        {
            get
            {
                foreach (var field in _type.Fields)
                {
                    yield return new FieldVM(field);
                }

                if (_type.Fields?.Count > 0)
                {
                    yield return " ";
                }

                foreach (var property in _type.Properties)
                {
                    yield return new PropertyVM(property);
                }
                
                if (_type.Properties?.Count > 0)
                {
                    yield return " ";
                }

                foreach (var method in _type.Methods)
                {
                    yield return new MethodVM(method);
                }
            }
        }

        public TypeVM(TypeInf type)
        {
            _type = type;
        }
    }
}