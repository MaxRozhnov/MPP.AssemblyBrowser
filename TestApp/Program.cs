using System.Reflection;
using AssemblyBrowserLib;

namespace TestApp


{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var browser = new AssemblyBrowser();
            browser.GetAssemblyInfo(Assembly.LoadFrom("C:\\Users\\Max\\RiderProjects\\Lab Task 3\\TestAssembly\\bin\\Debug\\TestAssembly.dll"));
        }
    }
}