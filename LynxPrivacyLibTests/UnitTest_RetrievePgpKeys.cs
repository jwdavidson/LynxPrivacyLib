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
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> {"testuser@example_com.pkr"}, 
                "jwdavidson+BcPGPTest@gmail_com.skr", 
                new char[] { 'W', 'i', '7', 'a', 'r', 'y', '!', 'T', 'e', 's', 't' }, 
                @"C:\Users\John\BcPGP\");

            Assert.IsNotNull(keySet.PrivateKey);
            Assert.IsNotNull(keySet.PublicKeys);
            Assert.IsNotNull(keySet.SecretKey);

            Assert.IsTrue(keySet.PublicKeys[0].BitStrength == 4096);
            Assert.IsTrue(keySet.PrivateKey.Key.IsPrivate);
            Assert.IsTrue(keySet.SecretKey.IsMasterKey);
        }
    }
}
