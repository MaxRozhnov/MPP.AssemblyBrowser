using System.Reflection;

namespace AssemblyBrowserLib
{
    public class PropertyInf
    {
        public string Name { get; set; }
        public string PropertyType { get; set; }

        public bool IsPublic { get; set; }
        public bool Writable { get; set; }
        public bool Readable { get; set; }



        public PropertyInf(PropertyInfo property)

        {

            Name = property.Name;
            PropertyType = property.PropertyType.Name;
            
            IsPublic = true;
            Readable = property.CanRead;
            Writable = property.CanWrite;

        }
    }
}