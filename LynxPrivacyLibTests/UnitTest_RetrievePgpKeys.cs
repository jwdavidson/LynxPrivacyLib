using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_RetrievePgpKeys
    {
        [TestMethod]
        public void TestMethod1()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "testuser@example_com_public.asc" },
                "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                @"C:\Users\John\BcPGP\", true);

            Assert.IsNotNull(keySet.PrivateKey);
            Assert.IsNotNull(keySet.PublicKeys);
            Assert.IsNotNull(keySet.SecretKey);

            Assert.IsTrue(keySet.PublicKeys[0].BitStrength == 4096);
            Assert.IsTrue(keySet.PrivateKey.Key.IsPrivate);
            Assert.IsTrue(keySet.SecretKey.IsMasterKey);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc" },
                "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                @"C:\Users\John\BcPGP\", false);

            Assert.IsNotNull(keySet.PrivateKey);
            Assert.IsNotNull(keySet.PublicKeys);
            Assert.IsNotNull(keySet.SecretKey);
            Assert.IsTrue(keySet.SecretKey.PublicKey.KeyId == keySet.PublicKeys[0].KeyId);

            Assert.IsTrue(keySet.PublicKeys[0].BitStrength == 4096);
            Assert.IsTrue(keySet.PrivateKey.Key.IsPrivate);
            Assert.IsTrue(keySet.SecretKey.IsMasterKey);
        }
        [TestMethod]
        public void TestMethod3()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "JWD_Kleopatra_Public.pgp" },
                "JWD_Kleopatra_Secret.asc",
                new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!'},
                @"C:\Users\John\BcPGP\", false);

            Assert.IsNotNull(keySet.PrivateKey);
            Assert.IsNotNull(keySet.PublicKeys);
            Assert.IsNotNull(keySet.SecretKey);
            Assert.IsTrue(keySet.SecretKey.PublicKey.KeyId == keySet.PublicKeys[0].KeyId);

            Assert.IsTrue(keySet.PublicKeys[0].BitStrength == 4096);
            Assert.IsTrue(keySet.PrivateKey.Key.IsPrivate);
            Assert.IsTrue(keySet.SecretKey.IsMasterKey);
        }
    }
}
