using Microsoft.Win32;

namespace AssemblyBrowser.Utils
{
    public class FileOpener
    {
        public string FilePath { get; set; }
        public bool OpenFileD()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            
            return false;

        }
    }
}