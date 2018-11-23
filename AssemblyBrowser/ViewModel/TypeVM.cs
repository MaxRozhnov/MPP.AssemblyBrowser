using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class TypeVM
    {
        private readonly TypeInf _type;
        private readonly List<object> _members;

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
                return _members;
            }
        }

        public TypeVM(TypeInf type)
        {
            _type = type;
            _members = new List<object>();
            
            foreach (var field in _type.Fields)
            {
                _members.Add(new FieldVM(field));
            }

            foreach (var property in _type.Properties)
            {
                _members.Add(new PropertyVM(property));
            }

            foreach (var method in _type.Methods)
            {
                _members.Add(new MethodVM(method));
            }
        }
    }
}