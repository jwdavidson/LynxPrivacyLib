using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_EncryptString
    {
        [TestMethod]
        public void TestMethod1()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc" },
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            StringBuilder testString = new StringBuilder();
            testString.AppendLine("This is some text to test the encryption algorithm in my code for PGP.");
            testString.AppendLine("This is a second line of text with a      series    of spaces  in the    middle of the text.");
            PgpEncryptString testEncrypt = new PgpEncryptString(keySet);
            string Returned = testEncrypt.EncryptAndSign(testString.ToString(), true);

        }
        [TestMethod]
        public void TestMethod2()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc",
                        "testuser@example_com_public.asc"},
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            StringBuilder testString = new StringBuilder();
            testString.AppendLine("This is some text to test the encryption algorithm in my code for PGP.");
            testString.AppendLine("This is a second line of text with a      series    of spaces  in the    middle of the text.");
            PgpEncryptString testEncrypt = new PgpEncryptString(keySet);
            string Returned = testEncrypt.EncryptAndSign(testString.ToString(), true);

        }
    }
}
