using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;

namespace LynxPrivacyLib
{
    public class KeySearchView
    {
        public KeySearchView(KeyserverPublicKey srchKey)
        {
            this.keyLine = srchKey.keyLine;
            this.keyId = srchKey.pubLine.keyId;
            if (srchKey.uidLines.Count > 0) this.uidString = srchKey.uidLines[0].uidString;
            this.keyCreatedDate = srchKey.pubLine.keyCreatedDate;
            this.keyExpiredDate = srchKey.pubLine.keyExpiredDate;
            this.algorithm = ((PublicKeyAlgorithmTag)srchKey.pubLine.algorithm).ToString();
            this.keySize = srchKey.pubLine.keySize;
        }

        public int keyLine { get; private set; }
        public string keyId { get; private set; }
        public string uidString { get; private set; }
        public DateTime keyCreatedDate { get; private set; }
        public DateTime keyExpiredDate { get; private set; }
        public string algorithm { get; private set; }
        public int keySize { get; private set; }
    }
}
