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
    public class UnitTest_EncryptFile
    {
        [TestMethod]
        public void TestMethod1()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc" },
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".pgp", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile);
            }


        }
        [TestMethod]
        public void TestMethod2()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc",
                        "testuser@example_com_public.asc"},
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".pgp", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile);
            }


        }
        [TestMethod]
        public void TestMethod3_SignOnly()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc",
                        "testuser@example_com_public.asc"},
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".sig", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile, false, true);
            }
        }
        [TestMethod]
        public void TestMethod4_ArmouredOutput()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc",
                        "testuser@example_com_public.asc"},
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".pgp", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile, true);
            }
        }
        [TestMethod]
        public void TestMethod5_SelfArmouredOutput()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc" },
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".pgp", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile, true);
            }

        }
        [TestMethod]
        public void TestMethod6_ArmouredSign()
        {
            RetrievePgpKeys keySet = new RetrievePgpKeys(new List<string> { "jwdavidson+BcPGPTest@gmail_com_public.asc",
                        "testuser@example_com_public.asc"},
                    "jwdavidson+BcPGPTest@gmail_com_secret.asc",
                    new char[] { 'W', 'i', '7', 'a', 'r', 'd', 'r', 'y', '!', 'T', 'e', 's', 't' },
                    @"C:\Users\John\BcPGP\", true);
            PgpEncryptFile testEncrypt = new PgpEncryptFile(keySet);
            FileInfo testFile = new FileInfo(@"C:\Users\John\BcPGP\AliceInWonderland.txt");
            using (FileStream myStream = new FileStream(testFile.FullName + ".sig", FileMode.Create, FileAccess.Write)) {
                testEncrypt.EncryptAndSign(myStream, testFile, true, true);
            }
        }
    }
}
