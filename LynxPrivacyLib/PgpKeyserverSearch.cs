using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace LynxPrivacyLib
{
    public class PgpKeyserverSearch
    {

        //string infoRegex = "^(?<info>info):1:(?<noKeys>[0-9]*)";

        string srchString = "pks/lookup?search={0}&op=index&options=mr";

        public List<KeyserverPublicKey> m_SearchResults { get; private set;}

        private HttpClient client;

        public PgpKeyserverSearch(string baseAddress)
        {
            HttpClientHandler clHandler = new HttpClientHandler();
            client = new HttpClient(clHandler);

            client.BaseAddress = new Uri(baseAddress);
            m_SearchResults = new List<KeyserverPublicKey>();
        }

        public async Task ReadResults(string searchValue)
        {
            string resp = await client.GetStringAsync(string.Format(srchString, searchValue));
            if (!string.IsNullOrEmpty(resp)) {

                int keyLine = 0;
                int uidLineCnt = 0;
                KeyserverPublicKey svrPublicKey = new KeyserverPublicKey();
                bool saveSvrEntry = false;
                foreach (string respLine in resp.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries)) {
                    string[] lineType = respLine.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                    if (lineType != null && lineType.Count() > 0) {
                        switch (lineType[0]) {
                            case "info":
                                break;
                            case "pub":
                                svrPublicKey.keyLine = keyLine++;
                                uidLineCnt = 0;
                                if (saveSvrEntry) m_SearchResults.Add(svrPublicKey);
                                svrPublicKey = new KeyserverPublicKey();
                                saveSvrEntry = true;
                                svrPublicKey.pubLine = new PubLine(respLine);
                                svrPublicKey.uidLines = new List<UidLine>();
                                break;
                            case "uid":
                                svrPublicKey.uidLines.Add(new UidLine(respLine, uidLineCnt++));
                                break;
                            default:
                                break;
                        }
                    }
                }
                m_SearchResults.Add(svrPublicKey); // get the last entry
            }
        }

 

    }

    public class KeyserverPublicKey
    {
        public int keyLine { get; internal set; }
        public PubLine pubLine { get; internal set; }
        public List<UidLine> uidLines { get; internal set; }

    }

    public class PubLine
    {
        private string pubRegex = "(?<pub>pub):(?<keyID>[a-fA-F0-9]*):(?<algorithm>[0-9]*):(?<keySize>[0-9]*):(?<createdSeconds>[0-9]*):(?<expiredSeconds>[0-9]*):(?<flags>[der]{0,3})";
        public string keyId { get; private set; }
        public int algorithm { get; private set; }
        public int keySize { get; private set; }
        public DateTime keyCreatedDate { get; private set; }
        public DateTime keyExpiredDate { get; private set; }
        public string keyFlags { get; private set; }

        public PubLine(string pubLine)
        {
            Match match = Regex.Match(pubLine, pubRegex, RegexOptions.Compiled);
            if (match != null) {
                keyId = match.Groups["keyID"] != null ? match.Groups["keyID"].Value : string.Empty;
                algorithm = match.Groups["algorithm"] != null ? Convert.ToInt32(match.Groups["algorithm"].Value) : 0;
                keySize = match.Groups["keySize"] != null ? Convert.ToInt32(match.Groups["keySize"].Value) : 0;
                int secCreated = match.Groups["createdSeconds"] != null ? Convert.ToInt32(match.Groups["createdSeconds"].Value) : 0;
                keyCreatedDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(secCreated);
                int secExpired = (match.Groups["expiredSeconds"] != null && (!string.IsNullOrEmpty(match.Groups["expiredSeconds"].Value))) ? Convert.ToInt32(match.Groups["expiredSeconds"].Value) : 0;
                keyExpiredDate = secExpired == 0 ? new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(secExpired) : DateTime.MinValue;
                keyFlags = match.Groups["flags"] != null ? match.Groups["flags"].Value : string.Empty;
            }
        }
    }

    public class UidLine
    {
        private string uidRegex = "(?<uid>uid):(?<uidString>[^:].*):(?<uidCreatedSeconds>[0-9]*):(?<uidExpiredSeconds>[0-9]*):(?<uidFlags>[der]{0,3})";
        public int uidLine { get; internal set; }
        public string uidString { get; internal set; }
        public DateTime uidCreatedDate { get; internal set; }
        public DateTime uidExpiredDate { get; internal set; }
        public string uidFlags { get; internal set; }

        public UidLine(string uidLineStr, int lineCnt)
        {
            Match match = Regex.Match(uidLineStr, uidRegex, RegexOptions.Compiled);
            uidLine = lineCnt;
            if (match != null) {
                uidString = match.Groups["uidString"] != null ? match.Groups["uidString"].Value : string.Empty;
                int secCreated = match.Groups["uidCreatedSeconds"] != null ? Convert.ToInt32(match.Groups["uidCreatedSeconds"].Value) : 0;
                uidCreatedDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(secCreated);
                int secExpired = (match.Groups["uidExpiredSeconds"] != null && (!string.IsNullOrEmpty(match.Groups["uidExpiredSeconds"].Value))) ? Convert.ToInt32(match.Groups["uidExpiredSeconds"].Value) : 0;
                uidExpiredDate = secExpired == 0 ?new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(secExpired) : DateTime.MinValue;
                uidFlags = match.Groups["uidFlags"] != null ? match.Groups["uidFlags"].Value : string.Empty;
            }
        }
    }
}
