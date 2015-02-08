using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace LynxPrivacyLib
{
    public class RetrievePgpKeys
    {
        public List<PgpPublicKey> PublicKeys { get; private set; }
        public PgpPrivateKey PrivateKey { get; private set; }
        public PgpSecretKey SecretKey { get; private set; }

        public RetrievePgpKeys(List<string> publicKeyNames, string privateKeyName, char[] passPhrase, string keyPath, bool toEncrypt)
        {
            if (publicKeyNames == null || publicKeyNames.Count <= 0)
                throw new ArgumentNullException("publicKeyName");
            if (string.IsNullOrEmpty(privateKeyName))
                throw new ArgumentNullException("privateKeyName");
            if (passPhrase == null || passPhrase.Count() <= 0)
                throw new ArgumentNullException("passPhrase");
            if (string.IsNullOrEmpty(keyPath))
                throw new ArgumentNullException("keyPath");
            foreach (string publicKeyName in publicKeyNames) {
                if (!File.Exists(Path.Combine(keyPath, publicKeyName)))
                    throw new FileNotFoundException(string.Format("publicKeyNames: {0}", publicKeyName));
            }
            if (!File.Exists(Path.Combine(keyPath, privateKeyName)))
                throw new FileNotFoundException("privateKeyName");

            PublicKeys = new List<PgpPublicKey>();

            foreach (string publicKeyName in publicKeyNames) {
                PublicKeys.Add(ReadPublicKey(Path.Combine(keyPath, publicKeyName)));
            }
            SecretKey = ReadSecretKey(Path.Combine(keyPath, privateKeyName), toEncrypt);
            PrivateKey = ReadPrivateKey(passPhrase);

        }

        // Gets the data from the database
        public RetrievePgpKeys(List<string> publicKeyEmails, string privateKeyEmail, char[] passPhrase, bool toEncrypt, KeyStoreDB keyStoreDb)
        {
            if (publicKeyEmails == null || publicKeyEmails.Count <= 0)
                throw new ArgumentNullException("publicKeyName");
            if (string.IsNullOrEmpty(privateKeyEmail))
                throw new ArgumentNullException("privateKeyName");
            if (passPhrase == null || passPhrase.Count() <= 0)
                throw new ArgumentNullException("passPhrase");

            PublicKeys = new List<PgpPublicKey>();

            foreach (string publicKeyEmail in publicKeyEmails) {
                KeyUsers keyUser = keyStoreDb.KeyUsers.Where(u => u.Email == publicKeyEmail).FirstOrDefault();
                if (keyUser != null)
                    PublicKeys.Add(ReadPublicKey(keyUser.KeyStoreID, keyStoreDb));
            }
            KeyUsers keySecUser = keyStoreDb.KeyUsers.Where(u => u.Email == privateKeyEmail).FirstOrDefault();
            SecretKey = ReadSecretKey(keySecUser.KeyStoreID, keyStoreDb, toEncrypt);
            PrivateKey = ReadPrivateKey(passPhrase);

        }

        private PgpSecretKey ReadSecretKey(long keyId, KeyStoreDB keyStoreDb, bool toEncrypt)
        {
            string armouredKeyFile = keyStoreDb.KeyStores.Find(keyId).ArmouredKeyFile;
            using (Stream keyIn = new MemoryStream(Encoding.UTF8.GetBytes(armouredKeyFile))){
                using (Stream inputStream = PgpUtilities.GetDecoderStream(keyIn)) {
                    PgpSecretKeyRingBundle secretKeyRingBundle = new PgpSecretKeyRingBundle(inputStream);
                    PgpSecretKey foundKey = toEncrypt ? GetFirstSecretKey(secretKeyRingBundle) : GetLastSecretKey(secretKeyRingBundle);
                    if (foundKey != null)
                        return foundKey;
                }
            }
            throw new Exception("Unable to find signing key in key ring.");
        }

        private PgpSecretKey ReadSecretKey(string privateKeyPath, bool toEncrypt)
        {
            using (Stream keyIn = File.OpenRead(privateKeyPath)) {
                using (Stream inputStream = PgpUtilities.GetDecoderStream(keyIn)) {
                    PgpSecretKeyRingBundle secretKeyRingBundle = new PgpSecretKeyRingBundle(inputStream);
                    PgpSecretKey foundKey = toEncrypt ? GetFirstSecretKey(secretKeyRingBundle) : GetLastSecretKey(secretKeyRingBundle);
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

        private PgpSecretKey GetLastSecretKey(PgpSecretKeyRingBundle secretKeyRingBundle)
        {
            return (from PgpSecretKeyRing kRing in secretKeyRingBundle.GetKeyRings()
                    select kRing.GetSecretKeys().Cast<PgpSecretKey>()
                                                    .LastOrDefault(k => k.IsSigningKey))
                                                    .LastOrDefault(key => key != null);
        }

        private PgpPublicKey ReadPublicKey(long keyId, KeyStoreDB keyStoreDb)
        {
            string armouredKeyFile = keyStoreDb.KeyStores.Find(keyId).ArmouredKeyFile;
            using (Stream keyIn = new MemoryStream(Encoding.UTF8.GetBytes(armouredKeyFile))){
                using (Stream inputStream = PgpUtilities.GetDecoderStream(keyIn)) {
                    PgpPublicKeyRingBundle publicKeyRingBundle = new PgpPublicKeyRingBundle(inputStream);
                    PgpPublicKey foundKey = GetFirstPublicKey(publicKeyRingBundle);
                    if (foundKey != null)
                        return foundKey;
                }
            }
            throw new Exception("Unable to find encryption key in public key ring.");
        }

        private PgpPublicKey ReadPublicKey(string publicKeyPath)
        {
            using (Stream keyIn = File.OpenRead(publicKeyPath)) {
                using (Stream inputStream = PgpUtilities.GetDecoderStream(keyIn)) {
                    PgpPublicKeyRingBundle publicKeyRingBundle = new PgpPublicKeyRingBundle(inputStream);
                    PgpPublicKey foundKey = GetFirstPublicKey(publicKeyRingBundle);
                    if (foundKey != null)
                        return foundKey;
                }
            }
            throw new Exception("Unable to find encryption key in public key ring.");
        }


        private PgpPublicKey GetFirstPublicKey(PgpPublicKeyRingBundle publicKeyRingBundle)
        {
            foreach (PgpPublicKeyRing kRing in publicKeyRingBundle.GetKeyRings()) {
                PgpPublicKey key = kRing.GetPublicKeys()
                    .Cast<PgpPublicKey>()
                    .Where(k => k.IsEncryptionKey).FirstOrDefault();
                if (key != null)
                    return key;
            }
            return null;
        }

        private PgpPrivateKey ReadPrivateKey(char[] passPhrase)
        {
            PgpPrivateKey privateKey = SecretKey.ExtractPrivateKey(passPhrase);
            if (privateKey != null)
                return privateKey;

            throw new Exception("No private key found in secret key.");
        }
    }
}
