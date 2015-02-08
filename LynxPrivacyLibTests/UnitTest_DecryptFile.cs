using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_DecryptFile
    {
        [TestMethod]
        public void TestMethod1()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc" },
                "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                @"C:\Users\John\BcPGP\", false);

            PgpDecryptFile testDescrypt = new PgpDecryptFile(@"C:\Users\John\BcPGP\AliceInWonderland.txt.pgp", keySet, 
                            @"C:\Users\John\BcPGP\");
            FileStream fs = File.Open(@"C:\Users\John\BcPGP\AliceInWonderland.txt.pgp", FileMode.Open);
            testDescrypt.Decrypt(fs, @"C:\Users\John\BcPGP\");
        }
    }
}
