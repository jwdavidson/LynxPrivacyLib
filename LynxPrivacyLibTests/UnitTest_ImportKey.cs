using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_ImportKey
    {
        private bool m_keysGenerated { get; set; }
        [TestMethod]
        public async Task TestMethod1()
        {
            if (!m_keysGenerated) {
                await GenerateKeys.GenerateKeyRing("John W. Davidson <testuser@example.com>", new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' }, @"C:\Users\John\BcPGP\");
                m_keysGenerated = true;
            }
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cnt = impKey.ImportPublicKey("testuser@example.com.public.asc", @"C:\Users\John\BcPGP", keyDB);
                Assert.IsTrue(cnt == 1);
            }
        }
        [TestMethod]
        public async Task TestMethod2()
        {
            if (!m_keysGenerated) {
                await GenerateKeys.GenerateKeyRing("John W. Davidson <testuser@example.com>", new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' }, @"C:\Users\John\BcPGP\");
                m_keysGenerated = true;
            }
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cnt = impKey.ImportSecretKey("testuser@example.com.secret.asc", @"C:\Users\John\BcPGP", keyDB);
                Assert.IsTrue(cnt == 1);
            }
        }
    }
}
