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
    public class ImportKey
    {

        string strRegex = @"(?<user>.[^(]*)\((?<comment1>.[^)]*).*<(?<email>.*)>.*\((?<comment2>.[^)]*)\)|^(?<user>.[^(<]*)\((?<comment1>.[^)<]*).*<(?<email>.*)>|^(?<user>.[^<]*)<(?<email>.*)>";
        public int ImportPublicKey(string fileName, string filePath, KeyStoreDB keyStoreDB)
        {
            int cntImport = 0;
            string keyPath = Path.Combine(filePath, fileName);
            string stringFileContent = File.ReadAllText(keyPath);
            PgpPublicKey pubKey = ReadPublicKey(keyPath);

            try {
                keyStoreDB.KeyStores.Add(new KeyStores() {
                    KeyStoreID = pubKey.KeyId,
                    ArmouredKeyFile = stringFileContent,
                    Fingerprint = pubKey.GetFingerprint(),
                    CreationTime = pubKey.CreationTime,
                    ValidDays = pubKey.ValidDays,
                    IsEncryptionKey = pubKey.IsEncryptionKey,
                    IsMasterKey = pubKey.IsMasterKey,
                    IsSigningKey = false,
                    IsRevoked = pubKey.IsRevoked(),
                    KeyType = "Public"
                });
                IEnumerable userIDs = pubKey.GetUserIds();
                foreach (string userId in userIDs) {
                    Match match = Regex.Match(userId, strRegex, RegexOptions.Compiled);
                    if (match != null) {
                        string comment1 = match.Groups["comment1"] != null ? match.Groups["comment1"].Value : string.Empty;
                        string comment2 = match.Groups["comment2"] != null ? match.Groups["comment2"].Value : string.Empty;
                        if (!string.IsNullOrEmpty(comment2))
                            comment1 += " " + comment2;
                        keyStoreDB.KeyUsers.Add(new KeyUsers() {
                            KeyStoreID = pubKey.KeyId,
                            UserName = match.Groups["user"] != null ? match.Groups["user"].Value : string.Empty,
                            Email = match.Groups["email"] != null ? match.Groups["email"].Value : string.Empty,
                            Comment = comment1
                        });
                    }
                }
                keyStoreDB.SaveChanges();
            }
            catch (DbUpdateConcurrencyException dbConEx) {
                throw new DbUpdateConcurrencyException(dbConEx.Message);
            }
            catch (DbUpdateException dbEx) {
                throw new DbUpdateException(dbEx.Message);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return ++cntImport;
        }

        public int ImportSecretKey(string fileName, string filePath, KeyStoreDB keyStoreDB)
        {
            int cntImport = 0;

            string keyPath = Path.Combine(filePath, fileName);
            string stringFileContent = File.ReadAllText(keyPath);
            PgpSecretKey secKey = ReadSecretKey(keyPath, true);

            bool removed = RemovePublicKeyForSecretKey(secKey.KeyId, keyStoreDB);

            try {
                keyStoreDB.KeyStores.Add(new KeyStores() {
                    KeyStoreID = secKey.KeyId,
                    ArmouredKeyFile = stringFileContent,
                    Fingerprint = secKey.PublicKey.GetFingerprint(),
                    CreationTime = secKey.PublicKey.CreationTime,
                    ValidDays = secKey.PublicKey.ValidDays,
                    IsEncryptionKey = false,
                    IsMasterKey = secKey.IsMasterKey,
                    IsSigningKey = secKey.IsSigningKey,
                    IsRevoked = secKey.PublicKey.IsRevoked(),
                    KeyType = "Secret"
                });
                IEnumerable userIDs = secKey.UserIds;
                foreach (string userId in userIDs) {
                    Match match = Regex.Match(userId, strRegex, RegexOptions.Compiled);
                    if (match != null) {
                        string comment1 = match.Groups["comment1"] != null ? match.Groups["comment1"].Value : string.Empty;
                        string comment2 = match.Groups["comment2"] != null ? match.Groups["comment2"].Value : string.Empty;
                        if (!string.IsNullOrEmpty(comment2))
                            comment1 += " " + comment2;
                        keyStoreDB.KeyUsers.Add(new KeyUsers() {
                            KeyStoreID = secKey.KeyId,
                            UserName = match.Groups["user"] != null ? match.Groups["user"].Value : string.Empty,
                            Email = match.Groups["email"] != null ? match.Groups["email"].Value : string.Empty,
                            Comment = comment1
                        });
                    }
                }
                keyStoreDB.SaveChanges();
            }
            catch (DbUpdateConcurrencyException dbConEx) {
                throw new DbUpdateConcurrencyException(dbConEx.Message);
            }
            catch (DbUpdateException dbEx) {
                throw new DbUpdateException(dbEx.Message);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return ++cntImport;
        }

        private bool RemovePublicKeyForSecretKey(long keyId, KeyStoreDB keyStoreDB)
        {
            KeyStores pubKeyDelete = keyStoreDB.KeyStores.Find(keyId);
            if (pubKeyDelete != null) {
                KeyUsers pubUserDelete = keyStoreDB.KeyUsers.Find(keyId);
                if (pubUserDelete != null)
                    keyStoreDB.KeyUsers.Remove(pubUserDelete);
                keyStoreDB.KeyStores.Remove(pubKeyDelete);
                keyStoreDB.SaveChanges();
            }
            return true;
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



    }
}
