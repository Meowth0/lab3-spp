using System.Collections.Generic;

namespace AssemblyBrowser
{
    public class AssemblyResult
    {
        private List<NamespaceInfo> _namespaces;

        public List<NamespaceInfo> Namespaces
        {
            get
            {
                return _namespaces;
            }

            set
            {
                _namespaces = value;
            }
        }

        public AssemblyResult()
        {
            Namespaces = new List<NamespaceInfo>();
        }


        public void AddNamespace(NamespaceInfo namespaceInfo)
        {
            Namespaces.Add(namespaceInfo);
        }


        public NamespaceInfo FindNamespace(string name)
        {
            name = "namespace " + name;
            return Namespaces.Find(x => x.Name == name);
        }

       
        public void Clear()
        {
            Namespaces.Clear();
        }
    }
}
