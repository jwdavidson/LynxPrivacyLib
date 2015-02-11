using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_PassphraseChange
    {
        [ClassInitialize]
        public static void InitClass(TestContext ctx)
        {
            string secretKeyFile = @"-----BEGIN PGP PRIVATE KEY BLOCK-----
Version: BCPG C# v1.7.4137.9688

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
BQ7R6w==
=Z4JC
-----END PGP PRIVATE KEY BLOCK-----";

            File.WriteAllText(Path.Combine(@"C:\Users\John\BcPGP", "testuser1@example_com_secret.asc"), secretKeyFile);
            ImportKey impKey = new ImportKey();
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                int cnt = impKey.ImportSecretKey("testuser1@example_com_secret.asc", @"C:\Users\John\BcPGP", keyDB);
            }

        }

        [TestMethod]
        public void TestMethod1()
        {
            long keyId = 0;
            string originalArmour = string.Empty;
            using (KeyStoreDB keyDB = new KeyStoreDB()) {
                RetrievePgpKeys keySet = new RetrievePgpKeys("testuser1@example.com", true, keyDB);
                keyId = keySet.SecretKey.KeyId;
                originalArmour = keyDB.KeyStores.Find(keyId).ArmouredKeyFile;
                PgpSecretKeyPassphraseChange.KeyChangePassphrase(keySet.SecretKey, new char[] { 't', 'e', 's', 't', 'u', 's', 'e', 'r' },
                    new char[] { 't', 'e', 's', 't', 'u', 's', 'e', 'r', '1' }, keyDB, string.Empty);
            }
            using (KeyStoreDB keyDbNew = new KeyStoreDB()) {
                string newArmour = keyDbNew.KeyStores.Find(keyId).ArmouredKeyFile;
                Assert.IsFalse(originalArmour.Equals(newArmour));
            }
            
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //File.Delete(Path.Combine(@"C:\Users\John\BcPGP\", "testuser1@example_com_secret.asc"));
            //using (KeyStoreDB keyDB = new KeyStoreDB()) {
            //    KeyUsers user = keyDB.KeyUsers.Where(u => u.Email == "testuser1@example.com").FirstOrDefault();
            //    KeyStores key = keyDB.KeyStores.Find(user.KeyStoreID);
            //    keyDB.KeyUsers.Remove(user);
            //    keyDB.KeyStores.Remove(key);
            //    keyDB.SaveChanges();
            //}

        }
    }
}
