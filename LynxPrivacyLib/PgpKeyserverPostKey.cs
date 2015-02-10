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
    public class PgpKeyserverPostKey
    {
        string postString = "pks/add";

        private HttpClient client;

        public PgpKeyserverPostKey(string baseAddress)
        {
            HttpClientHandler clHandler = new HttpClientHandler();
            client = new HttpClient(clHandler);

            client.BaseAddress = new Uri(baseAddress);
        }

        public async Task SendKeyToKeyserver(string keyData)
        {
            StringContent strKeyData = new StringContent(keyData);
            HttpResponseMessage resp = await client.PostAsync(postString, strKeyData);

        }

    }
}
