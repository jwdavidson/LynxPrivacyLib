using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;


namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_GenerateKeys
    {
        [TestMethod]
        public void TestMethod1()
        {
            GenerateKeys.GenerateKeyRing("John W. Davidson <jwdavidson+BcPGPTest@gmail.com>", new char[] { 'W','i','7','a','r','y', '!','T','e','s','t'}, @"C:\Users\John\BcPGP\");
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "jwdavidson+BcPGPTest@gmail_com.pkr")));
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "jwdavidson+BcPGPTest@gmail_com.skr")));
        }
        [TestMethod]
        public void TestMethod2()
        {
            GenerateKeys.GenerateKeyRing("Test User <testuser@example.com>", new char[] {'t','e','s','t','u','s','e','r'}, @"C:\Users\John\BcPGP\");
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "testuser@example_com.pkr")));
            Assert.IsTrue(File.Exists(Path.Combine(@"C:\Users\John\BcPGP\", "testuser@example_com.skr")));
        }
    }
}
