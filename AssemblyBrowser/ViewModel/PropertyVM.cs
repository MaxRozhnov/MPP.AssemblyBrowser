using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class PropertyVM
    {
        private readonly PropertyInf _property;

        public string PropertyStringRepresentation
        {
            get
            {
                var stringRepresentation = "public ";

                stringRepresentation += _property.PropertyType + " " + _property.Name;
                if (_property.Readable)
                {
                    stringRepresentation += "{ get; ";

                    if (_property.Writable)
                    {
                        stringRepresentation += " set; }";
                    }
                    else
                    {
                        stringRepresentation += "}";
                    }
                }
                else
                {
                    if (_property.Writable)
                    {
                        stringRepresentation += "{ set; }";
                    }
                }

                return stringRepresentation;
            }
        }

        public PropertyVM(PropertyInf property)
        {
            _property = property;
        }
    }
    
    
}