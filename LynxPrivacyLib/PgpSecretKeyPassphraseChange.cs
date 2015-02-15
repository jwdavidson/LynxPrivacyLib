using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System.Diagnostics;


namespace LynxPrivacyLib
{
    public static class PgpSecretKeyPassphraseChange
    {
        public static void KeyChangePassphrase(PgpSecretKey key, char[] originalPhrase, char[] newPhrase, KeyStoreDB keyDb, string keyExportName)
        {
            string fileData = string.Empty;
            bool useTemp = false;

            if (key == null)
                throw new ArgumentNullException("key");
            if (keyDb == null)
                throw new ArgumentNullException("keyDb");
            if (originalPhrase == null || originalPhrase.Count() <= 0)
                throw new ArgumentNullException("originalPhrase");
            if (newPhrase == null || newPhrase.Count() <= 0)
                throw new ArgumentNullException("newPhrase");

            PgpSecretKey newKey = ChangePassprase(key, originalPhrase, newPhrase);
            Debug.Assert(key.GetHashCode() != newKey.GetHashCode());
            if (newKey != null) {
                if (string.IsNullOrEmpty(keyExportName)) {
                    useTemp = true;
                    string tempPath = Path.GetTempPath();
                    keyExportName = Path.Combine(tempPath, Guid.NewGuid().ToString() + ".tmppgp");
                }
                ExportKey expKey = new ExportKey(keyDb);
                expKey.UpdateDbSecretKey(newKey, keyExportName);
                if (useTemp) {
                    //File.Delete(keyExportName);
                }
            }
        }
        public static PgpSecretKey ChangePassprase(PgpSecretKey key, char[] originalPhrase, char[] newPhrase)
        {
            try {
                return PgpSecretKey.CopyWithNewPassword(key, originalPhrase, newPhrase, key.KeyEncryptionAlgorithm, new SecureRandom());
            }
            catch (PgpException ex) {
                throw new PgpException(ex.Message);
            }
        }

    }
}
