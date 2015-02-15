using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace LynxPrivacyLib
{
    public class ExportKey
    {

        private KeyStoreDB m_keyStoreDb;

        public ExportKey(KeyStoreDB keyStoreDb)
        {
            m_keyStoreDb = keyStoreDb;
        }
        public void ExportDbKey(long keyId, string saveFileName)
        {
            File.WriteAllText(saveFileName, m_keyStoreDb.KeyStores.Find(keyId).ArmouredKeyFile);
        }

        public void ExportPublicKeyFromDbSecret(long keyId, string saveFileName)
        {
            PgpSecretKey secretKey = ReadSecretKey(keyId);

            Stream outFile = File.Create(saveFileName);
            outFile = new ArmoredOutputStream(outFile);
            PgpPublicKey publicKey = secretKey.PublicKey;
            publicKey.Encode(outFile);
            outFile.Close();

        }

        private PgpSecretKey ReadSecretKey(long keyId)
        {
            string armouredKeyFile = m_keyStoreDb.KeyStores.Find(keyId).ArmouredKeyFile;
            using (Stream keyIn = new MemoryStream(Encoding.UTF8.GetBytes(armouredKeyFile))) {
                using (Stream inputStream = PgpUtilities.GetDecoderStream(keyIn)) {
                    PgpSecretKeyRingBundle secretKeyRingBundle = new PgpSecretKeyRingBundle(inputStream);
                    PgpSecretKey foundKey = GetFirstSecretKey(secretKeyRingBundle);
                    if (foundKey != null)
                        return foundKey;
                }
            }
            throw new Exception("Unable to find signing key in key ring.");
        }

        private PgpSecretKey GetFirstSecretKey(PgpSecretKeyRingBundle secretKeyRingBundle)
        {
            foreach (PgpSecretKeyRing kRing in secretKeyRingBundle.GetKeyRings()) {
                PgpSecretKey key = kRing.GetSecretKeys()
                    .Cast<PgpSecretKey>()
                    .Where(k => k.IsSigningKey).FirstOrDefault();
                if (key != null)
                    return key;
            }
            return null;
        }

        public void UpdateDbSecretKey(PgpSecretKey key, string keyExportName)
        {
            Stream outFile = File.Create(keyExportName);
            Stream outArmor = new ArmoredOutputStream(outFile);
            string secKey = string.Empty;
            key.Encode(outArmor);
            outArmor.Close();
            using (StreamReader rdr = new StreamReader(outFile)) {
                rdr.BaseStream.Position = 0;
                secKey = rdr.ReadToEnd();
            }
            KeyStores updKey = m_keyStoreDb.KeyStores.Find(key.KeyId);
            updKey.ArmouredKeyFile = secKey;
            m_keyStoreDb.SaveChanges();

        }

    }
}
