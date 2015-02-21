using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxPrivacyLib
{
    public class KeyView
    {
        public KeyView(KeyStores keyData, long userId)
        {
            this.KeyType = keyData.KeyType;
            this.OwnerTrust = keyData.OwnerTrust;
            StringBuilder buildFingerprint = new StringBuilder();
            for (int x = 0; x < keyData.Fingerprint.Length; x++){
                buildFingerprint.Append(string.Format("{0} ", keyData.Fingerprint[x].ToString("X2")));
            }
            this.Fingerprint = buildFingerprint.ToString().TrimEnd(); ;
            this.IsEncryptionKey = keyData.IsEncryptionKey;
            this.IsSigningKey = keyData.IsSigningKey;
            this.IsMasterKey = keyData.IsMasterKey;
            this.ValidDays = keyData.ValidDays;
            this.CreationTime = keyData.CreationTime;
            this.KeyStoreId = keyData.KeyStoreID;
            KeyUsers userData = keyData.KeyUsers.Where(u => u.KeyUserID == userId).FirstOrDefault();
            if (userData != null) {
                this.KeyUserId = userData.KeyUserID;
                if (userData.UserName != null) this.UserName = userData.UserName;
                if (userData.Email != null) this.Email = userData.Email;
                if (userData.EncryptionType != null) this.EncryptionType = userData.EncryptionType;
                this.KeySize = userData.KeySize;
            }
        }

        public long KeyUserId { get; private set; }
        public long KeyStoreId { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string EncryptionType { get; private set; }
        public int KeySize { get; private set; }
        public DateTime CreationTime { get; private set; }
        public int ValidDays { get; private set; }
        public bool IsMasterKey { get; private set; }
        public bool IsSigningKey { get; private set; }
        public bool IsEncryptionKey { get; private set; }
        public string Fingerprint { get; private set; }
        public string OwnerTrust { get; private set; }
        public string KeyType { get; private set; }
    }
}
