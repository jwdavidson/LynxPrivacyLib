using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace LynxPrivacyLib
{
    public class PgpKeyserverGetKey
    {
        string srchString = "pks/lookup?op=get&search={0}&options=mr";

        private HttpClient client;

        public PgpKeyserverGetKey(string baseAddress)
        {
            HttpClientHandler clHandler = new HttpClientHandler();
            client = new HttpClient(clHandler);

            client.BaseAddress = new Uri(baseAddress);
        }

        public async Task ImportKey(string keyId, KeyStoreDB keyStoreDb)
        {
            ImportKey impKey = new ImportKey();
            string resp = await client.GetStringAsync(string.Format(srchString, keyId));
            if (!string.IsNullOrEmpty(resp)) {
                string tmpFileName = Guid.NewGuid().ToString() + ".tmp";
                string tmpPath = Path.GetTempPath().ToString();
                File.WriteAllText(Path.Combine(tmpPath, tmpFileName), resp);
                int cnt = impKey.ImportPublicKey(tmpFileName, tmpPath, keyStoreDb);
                File.Delete(Path.Combine(tmpPath, tmpFileName));
            }

        }
    }
}
