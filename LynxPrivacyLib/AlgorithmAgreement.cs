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
    public class AlgorithmAgreement
    {
        public HashAlgorithmTag AgreedHashAlgorithm { get; private set; }
        public SymmetricKeyAlgorithmTag AgreedSymmetricKeyAlgorithm { get; internal set; }
        public CompressionAlgorithmTag AgreedCompressionAlgorithm { get; internal set; }

        private List<int> certificationTypes = new List<int>() { PgpSignature.CasualCertification, 
                            PgpSignature.DefaultCertification, PgpSignature.NoCertification, PgpSignature.PositiveCertification};


        private List<SymmetricKeyAlgorithmTag> AllowedEncryptionAlgorithms = new List<SymmetricKeyAlgorithmTag>() { 
            SymmetricKeyAlgorithmTag.Aes256, SymmetricKeyAlgorithmTag.Aes192, SymmetricKeyAlgorithmTag.Aes128, 
            SymmetricKeyAlgorithmTag.Blowfish, SymmetricKeyAlgorithmTag.Twofish};

        private List<HashAlgorithmTag> AllowedHashAlgorithms = new List<HashAlgorithmTag>() {
            HashAlgorithmTag.Sha512, HashAlgorithmTag.Sha384, HashAlgorithmTag.Sha256,
            HashAlgorithmTag.Sha224, HashAlgorithmTag.RipeMD160, HashAlgorithmTag.Tiger192 };

        private List<CompressionAlgorithmTag> AllowedCompressionAlgorithms = new List<CompressionAlgorithmTag>() {
            CompressionAlgorithmTag.ZLib, CompressionAlgorithmTag.BZip2, CompressionAlgorithmTag.Zip};

        private List<KeySignatureSubpacketVectors> KeySigSpVectors { get; set; }

        public AlgorithmAgreement(List<PgpPublicKey> pubKeys)
        {
            KeySigSpVectors = new List<KeySignatureSubpacketVectors>();
            foreach (PgpPublicKey pubKey in pubKeys) {
                List<PgpSignatureSubpacketVector> pubKeySpvs = GetSignatureSubpacketVectors(pubKey);
                KeySignatureSubpacketVectors keySpvs = new KeySignatureSubpacketVectors() {
                    Key = pubKey,
                    SSpVectors = pubKeySpvs
                };
                KeySigSpVectors.Add(keySpvs);
            }
            GetAgreedHashAlgorithm();
            GetAgreedSymmetricKeyAlgorithm();
            GetAgreedCompressionAlgorithm();

        }

        private void GetAgreedHashAlgorithm()
        {
            List<HashAlgorithmTag> prefHash = AllowedHashAlgorithms;
            foreach (KeySignatureSubpacketVectors keySpvs in KeySigSpVectors) {
                List<HashAlgorithmTag> testPrefs = GetPreferredHashAlgorithmsForKey(keySpvs.SSpVectors);
                prefHash = prefHash.Intersect(testPrefs).ToList();
                if (prefHash.Count <= 0)
                    break;    // no need to test any further, use the default
            }
            if (prefHash.Count > 0)
                AgreedHashAlgorithm = prefHash[0]; //use the first, which will be the best possible
            else
                AgreedHashAlgorithm = HashAlgorithmTag.Sha1; // this is the unfortunate default
        }

        private List<HashAlgorithmTag> GetPreferredHashAlgorithmsForKey(List<PgpSignatureSubpacketVector> sspVectors)
        {
            List<HashAlgorithmTag> keyPrefs = new List<HashAlgorithmTag>();
            foreach (PgpSignatureSubpacketVector sspVector in sspVectors) {
                int[] intKeyPrefs = sspVector.GetPreferredHashAlgorithms();
                if (intKeyPrefs != null && intKeyPrefs.Length > 0) {
                    foreach (int intKeyPref in intKeyPrefs)
                        keyPrefs.Add((HashAlgorithmTag)intKeyPref);
                }
            }
            return keyPrefs;
        }

        private void GetAgreedSymmetricKeyAlgorithm()
        {
            List<SymmetricKeyAlgorithmTag> prefEncryption = AllowedEncryptionAlgorithms;
            foreach (KeySignatureSubpacketVectors keySpvs in KeySigSpVectors) {
                List<SymmetricKeyAlgorithmTag> testPrefs = GetPreferredSymmetricKeyAlgorithmsForKey(keySpvs.SSpVectors);
                prefEncryption = prefEncryption.Intersect(testPrefs).ToList(); ;
                if (prefEncryption.Count <= 0)
                    break;
            }
            if (prefEncryption.Count > 0)
                AgreedSymmetricKeyAlgorithm = prefEncryption[0];
            else
                AgreedSymmetricKeyAlgorithm = SymmetricKeyAlgorithmTag.TripleDes;
        }

        private List<SymmetricKeyAlgorithmTag> GetPreferredSymmetricKeyAlgorithmsForKey(List<PgpSignatureSubpacketVector> sspVectors)
        {
            List<SymmetricKeyAlgorithmTag> keyPrefs = new List<SymmetricKeyAlgorithmTag>();
            foreach (PgpSignatureSubpacketVector sspVector in sspVectors) {
                int[] intKeyPrefs = sspVector.GetPreferredSymmetricAlgorithms();
                if (intKeyPrefs != null && intKeyPrefs.Length > 0) {
                    foreach (int intKeyPref in intKeyPrefs)
                        keyPrefs.Add((SymmetricKeyAlgorithmTag)intKeyPref);
                }
            }
            return keyPrefs;
        }

        private void GetAgreedCompressionAlgorithm()
        {
            List<CompressionAlgorithmTag> prefCompression = AllowedCompressionAlgorithms;
            foreach (KeySignatureSubpacketVectors keySpvs in KeySigSpVectors) {
                List<CompressionAlgorithmTag> testPrefs = GetPreferredCompressionAlgorithmForKey(keySpvs.SSpVectors);
                prefCompression = prefCompression.Intersect(testPrefs).ToList();
                if (prefCompression.Count <= 0)
                    break;
            }
            if (prefCompression.Count > 0)
                AgreedCompressionAlgorithm = prefCompression[0];
            else
                AgreedCompressionAlgorithm = CompressionAlgorithmTag.Uncompressed;
        }

        private List<CompressionAlgorithmTag> GetPreferredCompressionAlgorithmForKey(List<PgpSignatureSubpacketVector> sspVectors)
        {
            List<CompressionAlgorithmTag> keyPrefs = new List<CompressionAlgorithmTag>();
            foreach (PgpSignatureSubpacketVector sspVector in sspVectors) {
                int[] intKeyPrefs = sspVector.GetPreferredCompressionAlgorithms();
                if (intKeyPrefs != null && intKeyPrefs.Length > 0) {
                    foreach (int intKeyPref in intKeyPrefs)
                        keyPrefs.Add((CompressionAlgorithmTag)intKeyPref);
                }
            }
            return keyPrefs;
        }

        private List<PgpSignatureSubpacketVector> GetSignatureSubpacketVectors(PgpPublicKey key)
        {
            List<PgpSignatureSubpacketVector> result = new List<PgpSignatureSubpacketVector>();
            if (key.IsMasterKey) {
                foreach (int certificationType in certificationTypes) {
                    foreach (PgpSignature sig in key.GetSignaturesOfType(certificationType)) {
                        if (sig.HasSubpackets)
                            result.Add(sig.GetHashedSubPackets());
                    }
                }
            } else {
                foreach (PgpSignature sig in key.GetSignaturesOfType(PgpSignature.SubkeyBinding)) {
                    if (sig.HasSubpackets)
                        result.Add(sig.GetHashedSubPackets());
                }
            }
            return result;
        }



    }

    internal class KeySignatureSubpacketVectors
    {
        internal PgpPublicKey Key { get; set; }
        internal List<PgpSignatureSubpacketVector> SSpVectors { get; set; }
    }
}
