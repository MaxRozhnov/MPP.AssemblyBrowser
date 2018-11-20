using System.Reflection;

namespace AssemblyBrowserLib
{
    public class MethodInf
    {
        
        public string Name { get; }
        public string Signature { get; }

        public bool IsPublic { get; }
        public bool IsStatic { get; }
        public bool IsVirtual { get; }
        public bool IsFinal { get; }

        public MethodInf(MethodInfo method)
        {         
            Name = method.Name;
            Signature = method.ToString();
            
            IsStatic = method.IsStatic;
            IsVirtual = method.IsVirtual;
            IsFinal = method.IsFinal;
            IsPublic = method.IsPublic;
        }
    }
}