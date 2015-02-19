using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;


namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_GenerateKeys
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            await GenerateKeys.GenerateKeyRing("John W. Davidson <jwdavidson+BcPGPTest@gmail.com>", new char[] { 'W','i','7','a','r','d','r','y', '!','T','e','s','t'}, @"C:\Users\John\BcPGP\");
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "jwdavidson+BcPGPTest@gmail_com_public.asc")));
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "jwdavidson+BcPGPTest@gmail_com_secret.asc")));
        }
        [TestMethod]
        public async Task TestMethod2()
        {
            await GenerateKeys.GenerateKeyRing("Test User <testuser@example.com>", new char[] {'t','e','s','t','u','s','e','r'}, @"C:\Users\John\BcPGP\");
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "testuser@example.com.public.asc")));
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "testuser@example.com.secret.asc")));
        }
    }
}
