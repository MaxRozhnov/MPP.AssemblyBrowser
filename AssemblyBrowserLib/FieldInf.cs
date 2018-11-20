using System.Reflection;

namespace AssemblyBrowserLib
{
    public class FieldInf
    {
        public string Name { get; }
        public string FieldType { get; }

        public bool IsPublic { get; }
        public bool IsStatic { get; }

        public FieldInf(FieldInfo field)
        {
            Name = field.Name;
            FieldType = field.FieldType.Name;
            
            IsPublic = field.IsPublic;
            IsStatic = field.IsStatic;
        }




    }
}