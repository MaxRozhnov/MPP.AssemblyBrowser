using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;
using AssemblyBrowser.Utils;
using AssemblyBrowserLib;

namespace AssemblyBrowser.ViewModel
{
    public class VMMain : VMBase
    {
        private List<NamespaceInf> assemblyContent;
        private DelegateCommand _delegateCommand;
        private FileOpener _fileOpener;

        
        public List<NamespaceVM> Namespaces
        {
            get
            {
                List<NamespaceVM> namespaces = new List<NamespaceVM>();
                foreach (var namespaceInf in assemblyContent)
                {
                    namespaces.Add(new NamespaceVM(namespaceInf));
                }

                return namespaces;
            }
        }

        public DelegateCommand LoadAssembly
        {
            get => _delegateCommand = new DelegateCommand(obj =>
            {
                AssemblyBrowserLib.AssemblyBrowser assemblyBrowser = new AssemblyBrowserLib.AssemblyBrowser();
                if (_fileOpener.OpenFileD())
                {
                    assemblyContent = assemblyBrowser.GetAssemblyTypes(_fileOpener.FilePath);
                    OnPropertyChanged(nameof(Namespaces));
                }
            }); 
        }
        
        public VMMain()
        {
            _fileOpener = new FileOpener();
            assemblyContent = new List<NamespaceInf>();
        }

    }
}