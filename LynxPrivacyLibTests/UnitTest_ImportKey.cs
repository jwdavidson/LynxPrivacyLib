using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_ImportKey
    {
        [TestMethod]
        public void TestMethod1()
        {
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cnt = impKey.ImportPublicKey("testuser@example_com_public.asc", @"C:\Users\John\BcPGP", keyDB);
                Assert.IsTrue(cnt == 1);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cnt = impKey.ImportSecretKey("testuser@example_com_secret.asc", @"C:\Users\John\BcPGP", keyDB);
                Assert.IsTrue(cnt == 1);
            }
        }
    }
}
