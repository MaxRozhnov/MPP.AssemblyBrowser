using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class FieldVM
    {
        private readonly FieldInf _field;

        public string FieldStringRepresentation
        {
            get
            {
                var stringRepresentation = "public ";
                if (_field.IsStatic)
                {
                    stringRepresentation += "static";
                }

                stringRepresentation += _field.FieldType + " " + _field.Name;
                return stringRepresentation;
            }
        }

        public FieldVM(FieldInf field)
        {
            _field = field;
        }

    }
}