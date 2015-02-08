using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_UpdateOwnerTrust
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool test = false;
            using (KeyStoreDB keyStoreDb = new KeyStoreDB()) {
                test = UpdateOwnerTrust.Update(keyStoreDb, -6021560623378548803, "full");
            }
            Assert.IsTrue(test);
        }
    }
}
