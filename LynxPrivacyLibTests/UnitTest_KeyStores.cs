using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LynxPrivacyLib;

namespace LynxPrivacyLibTests
{
    [TestClass]
    public class UnitTest_KeyStores
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (KeyStoreDB keysDB = new KeyStoreDB()) {
                bool checkDb = keysDB.Database.Exists();
                int cntItems = keysDB.KeyStores.Local.Count;
                keysDB.KeyStores.Add(new KeyStores() {
                    KeyStoreID = 123569878543,
                    KeyType = "Secret",
                    Fingerprint = new byte[] { 102, 56, 76, 56, 43, 45, 73, 94, 36, 23, 45, 60, 23, 34, 35, 36, 37, 38, 39, 89 },
                    CreationTime = DateTime.UtcNow,
                    ValidDays = 0,
                    ArmouredKeyFile = @"-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: BCPG C# v1.7.4137.9688

mQINBFTSnHcBEADM4C0Fb5PNLIHzgEX5zvcoyYuIQkYRcd57O9UISM5vm2Tf+SvD
9Eiwjx5g5eobh6UfsFHwcPQNJv4MHUWWYlnEzQW+mBSJRwT9HMt0an/l4G4cDAwA
zChNQDLYMW8cY9zGrxShBeJoqpIazbT3+gJhorGayD+ybTuu8NEnZpLyQDdhm5N+
4oJEvSAmGRUcbrPRPL2Anwiuz7VRU0P2UJW+RhOWFbdScuDdZKFSsczU3x/9pmDP
ktO83kMQ+EHnyyEOp1vJBbY6GN+DnH+Zqvb5IhRxUt+x1kupPnvGuIt87aD5Cvnp
DcPbNXp7hBKa3x/bY70EI+sQfRKbV8MTHnzz7XdIPo+gYu6WgLPlzE6SZJzIC0Q2
ADlOkLU+E0xLtzRgIlxM4KmMss41zPHsHEa3tcynQfoXi7b3gHmoPi2Byyi65aVg
G7vWwoOUistnXPw+uk9sVehFTAQkomMuV4lW3AUtfN6edT2Fn+W6G3O50O8P+1Tx
oCMxvxkjPvnhTIdqDcqBPxelYcbz7tDAY+bZaUHKsPNToTzdcIyrDKiJP+GmFB/f
WAytK6tNJik9Mwshhticqf3ooEMwNtfPyDPh+O+wAicmz+g5eeasOvrnLg6GxqTF
RZ0vtU5x6dgUzkPLtGEultHaxYO2tzBzH6rRj9CTrqWo0t65frfUFFYzlwARAQAB
tDFKb2huIFcuIERhdmlkc29uIDxqd2Rhdmlkc29uK0JjUEdQVGVzdEBnbWFpbC5j
b20+iQI2BBMBAgAgBQJU0px3AhsPBQsJCAcEBxUKCQgLAwYEFgIDAQMFCP8ACgkQ
ZrVC3J0H1WZ//A//WlUv/rF7vjgD4IYc7+5p8a5gkeUJ6WkaRMdn0SCiaO+F0FrQ
bgNiMHxeLXkkXd/LVaCQUXA+Xo84hQwDjZysRLKqFNj2thzbVwET5h9aoT9xee2/
qjy+wad+fQOdYtpyAZcAjcOISmHCMQ+YWhtczytehLHBUM47c4YrDKky6w/1jCVu
ZC2Ymx16Dfq5mzzVVr7w5TW1+fJtGSYtgHs9OhKPXp6nNdij7q1J1t35sNXSfb7U
WxQ9p2VtaSejURzlFfYbAWWWCeijdCQb3V/8spvsgNQOz9Q4+I9FiVEYjxRtfPwp
/PigjV8seVlGPST8qdmfzvj661KOTMob2Mfc2g7QOoCY397n5DbtUw1S9taRW7mw
9CAwtH2wbSeCRX3PgyLaC0cpKcLmp0iy0jZrIcuwnzfwYqvg1JqULl+AD3BBYe5V
R5bE+Kzc8RmC2Xg1IjCfBANS2n7UD7UkpaMvz4OevCAgI7gf46nOYb2h6nRlU103
de43hgjOC9PGfsn67VDuqSazxs8whogbuL4QOB69Itws6T0R8VUTkYpuzfp5vuWg
2g93IG0rwzyEuqLvXTy4P9z+PeTX/TabKYMilL4s4iNyoBeSUdyUGHmdTwc+QIzm
S8J8myy+rQTzzzn516mJSK8u/+8DfzZxJ9hm8ga4x5IUhDNl09rBDqlz2xw=
=CBBc
-----END PGP PUBLIC KEY BLOCK-----"
                });
                keysDB.SaveChanges();

                cntItems = keysDB.KeyStores.Local.Count;
                Assert.IsTrue(cntItems == 1);

            }
        }
    }
}
