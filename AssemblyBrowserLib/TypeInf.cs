using System;
using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public class TypeInfo
    {
       
        public List<FieldInf> Fields { get; }
        public List<PropertyInf> Properties { get; }
        public List<MethodInf> Methods { get; }
        
        public bool IsPublic { get; }
        public bool IsSealed { get; }
        public bool IsInterface { get; }
        public bool IsAbstract { get; }
        public bool IsClass { get; }
        
        public string Name { get; }
        
        public TypeInfo(Type type)
        {

            Fields = new List<FieldInf>();
            Properties = new List<PropertyInf>();
            Methods = new List<MethodInf>();
            
            Name = type.Name;
            IsPublic = type.IsPublic;
            IsSealed = type.IsSealed;
            IsInterface = type.IsInterface;
            IsAbstract = type.IsAbstract;
            IsClass = type.IsClass;
            
            RetrieveFields(type);
            RetrieveMethods(type);
            RetrieveProperties(type);

        }

        private void RetrieveMethods(Type type)
        {
            foreach (var method in type.GetMethods())
            {
                Methods.Add(new MethodInf(method));
            }  
        }

        private void RetrieveFields(Type type)
        {
            foreach (var field in type.GetFields())
            {
                Fields.Add(new FieldInf(field));
            }
        }

        private void RetrieveProperties(Type type)
        {
            foreach (var property in type.GetProperties())
            {
                Properties.Add(new PropertyInf(property));
            }
        }
    }
}