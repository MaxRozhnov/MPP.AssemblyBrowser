using System;
using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class MethodVM
    {
        private readonly MethodInf _method;

        public string MethodStringRepresentation
        {
            get
            {
                var stringRepresentation = "public ";
                if (_method.IsStatic)
                {
                    stringRepresentation += "static ";
                }else if(_method.IsVirtual && !_method.IsFinal)
                {
                    stringRepresentation += "virtual ";
                }

                stringRepresentation += _method.Signature + ";";


                return stringRepresentation;
            }
        }

        public MethodVM(MethodInf method)
        {
            _method = method;
        }
    }
}