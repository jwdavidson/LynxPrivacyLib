using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_KeyServerQuery
    {
        //string infoRegex = "^(?<info>info):1:(?<noKeys>[0-9]*)";
        //string pubRegex = "^(?<pub>pub)pub:(?<keyID>[a-fA-F0-9]*):(?<algorithm>[0-9]*):(?<keySize>[0-9]*):(?<createdSeconds>[0-9]*):(?<expiredSeconds>[0-90*):(?<flags>[der]{0,3})";
        //string uidRegex = "^(?<uid>uid):(?<uidString>[^:].*):(?<uidCreatedSeconds>[0-9]*):(?<uidExpiredSeconds>[0-9]*):(?<uidFlags>[der]{0,3})";

        [TestMethod]
        public async Task TestMethod1()
        {
            PgpKeyserverSearch newSearch = new PgpKeyserverSearch("http://keys.gnupg.net:11371/");
            await newSearch.ReadResults("dredmorbius");

            Assert.IsNotNull(newSearch.m_SearchResults);
            Assert.IsTrue(newSearch.m_SearchResults.Count == 2);
            Assert.IsTrue(newSearch.m_SearchResults[0].pubLine.keyId.Equals("c2109883ffb43ac1debf9a2cac6f1e84420ab7bd", StringComparison.InvariantCultureIgnoreCase));

        }
        [TestMethod]
        public async Task TestMethod2()
        {
            PgpKeyserverSearch newSearch = new PgpKeyserverSearch("http://keys.gnupg.net:11371/");
            await newSearch.ReadResults("0xc2109883ffb43ac1debf9a2cac6f1e84420ab7bd");

            Assert.IsNotNull(newSearch.m_SearchResults);
            Assert.IsTrue(newSearch.m_SearchResults.Count == 1);
            Assert.IsTrue(newSearch.m_SearchResults[0].pubLine.keyId.Equals("c2109883ffb43ac1debf9a2cac6f1e84420ab7bd", StringComparison.InvariantCultureIgnoreCase));

        }
        [TestMethod]
        public async Task TestMethod3()
        {
            PgpKeyserverGetKey getKey = new PgpKeyserverGetKey("http://keys.gnupg.net:11371/");
            using (KeyStoreDB keyStoreDb = new KeyStoreDB()) {
                await getKey.ImportKey("0xc2109883ffb43ac1debf9a2cac6f1e84420ab7bd", keyStoreDb);
            }


        }
    }
}
