using System;
using System.Reflection;

namespace AssemblyBrowser
{
    public class AssemblyBrowser
    {
        private Assembly _asm;
        

        public AssemblyResult Browse(string filename)
        {
            Type[] types;
            NamespaceInfo searchResult;
            AssemblyResult _result = new AssemblyResult(); 

            _asm = Assembly.LoadFrom(filename);
            types = _asm.GetTypes();
            _result.Clear();
            foreach (var type in types)
            {
                searchResult = _result.FindNamespace(type.Namespace);
                if (searchResult == null)
                {
                    searchResult = new NamespaceInfo(type.Namespace);
                    _result.AddNamespace(searchResult);
                }
                searchResult.AddClass(new ClassInfo(type));                
            }
            return _result;
        }
    }
}
