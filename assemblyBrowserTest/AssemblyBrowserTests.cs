using System;
using System.Collections.Generic;
using AssemblyBrowserLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace assemblyBrowserTest
{
    [TestClass]
    public class AssemblyBrowserTests
    {
        AssemblyBrowser browser;
        List<NamespaceInf> namespaces;

        [TestInitialize]
        public void Init()
        {
            string path = @"..\..\TestAssembly\TestAssembly.dll";
            browser = new AssemblyBrowser();
            namespaces = browser.GetAssemblyTypes(path);

        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(namespaces);
        }

        [TestMethod]
        public void GlobalNamespaceTest()
        {
            Assert.AreEqual("Global", namespaces[0].Name);
        }

        [TestMethod]
        public void NamespaceCountTest()
        {
            Assert.AreEqual(3, namespaces.Count);
        }

        [TestMethod]
        public void ClassNameTest()
        {
            Assert.AreEqual("NoNameSpaceClass", namespaces[0].Types[0].Name);
        }

        [TestMethod]
        public void PropetyNameTest()
        {
            Assert.AreEqual("TestProperty", namespaces[0].Types[0].Properties[0].Name);
        }

        [TestMethod]
        public void MethodNamesTest()
        {
            Assert.AreEqual("TestMethod1", namespaces[1].Types[0].Methods[0].Name);
            Assert.AreEqual("TestMethod2", namespaces[1].Types[0].Methods[1].Name);
            Assert.AreEqual("TestMethod3", namespaces[1].Types[0].Methods[2].Name);
        }
    }
}
