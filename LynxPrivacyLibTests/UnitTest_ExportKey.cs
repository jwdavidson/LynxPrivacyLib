using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_ExportKey
    {
        [TestMethod]
        public void TestMethod1()
        {
            KeyStoreDB keyStoreDb = new KeyStoreDB();
            ExportKey expKey = new ExportKey(keyStoreDb);
            expKey.ExportDbKey(keyStoreDb.KeyStores.Where(k => k.KeyStoreID != null).First().KeyStoreID, "ExportKey_Test1.asc");
            Assert.IsTrue(File.Exists("ExportKey_Test1.asc"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            KeyStoreDB keyStoreDb = new KeyStoreDB();
            ExportKey expKey = new ExportKey(keyStoreDb);
            expKey.ExportPublicKeyFromDbSecret(keyStoreDb.KeyStores.Where(k => k.KeyStoreID != null).First().KeyStoreID, "ExportKey_Test2.asc");
            Assert.IsTrue(File.Exists("ExportKey_Test2.asc"));
        }
    }
}
