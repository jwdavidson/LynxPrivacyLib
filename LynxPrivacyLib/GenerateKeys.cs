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


namespace LynxPrivacyLib
{
    public static class GenerateKeys
    {
        const uint P_EXPONENT = 0x10001;
        const int KEYLENGTH = 4096;
        const int CERTAINTY = 12;

        const int S2KCOUNT = 0xc0;



        public static void GenerateKeyRing(string userEmail, char[] password, string keyStorePath){

            if (string.IsNullOrEmpty(userEmail))
                throw new ArgumentNullException("userEmail");
            if (password == null || password.Count() <= 0)
                throw new ArgumentNullException("password");
            if (string.IsNullOrEmpty(keyStorePath))
                throw new ArgumentNullException("keyStorePath");

            string email = null;

            Regex regex = new Regex(@"<(?<email>.*)>");
            Match match = regex.Match(userEmail);
            if (match.Success) {
                email = match.Groups["email"].Value;
            } else
                throw new ArgumentException("userEmail not in correct format - User Name <email address>");

            PgpKeyRingGenerator krGen = generateKeyRingGenerator(userEmail, password);

            //Create public key ring and put in file
            PgpPublicKeyRing pkr = krGen.GeneratePublicKeyRing();
            using (FileStream pkrOut = new FileInfo(Path.Combine(keyStorePath, email.Replace(".", "_") + ".pkr")).OpenWrite()){
                using (Stream pkrOutStrm = new ArmoredOutputStream(pkrOut)) {
                    pkr.Encode(pkrOutStrm);
                    pkrOutStrm.Close();
                }
                pkrOut.Close();
            }

            PgpSecretKeyRing skr = krGen.GenerateSecretKeyRing();
            using (FileStream skrOut = new FileInfo(Path.Combine(keyStorePath, email.Replace(".", "_") + ".skr")).OpenWrite()) {
                using (Stream skrOutStrm = new ArmoredOutputStream(skrOut)) {
                    skr.Encode(skrOutStrm);
                    skrOutStrm.Close();
                }
                skrOut.Close();
            }
          
        }

        public static PgpKeyRingGenerator generateKeyRingGenerator(string userEmail, char[] password)
        {
            return generateKeyRingGenerator(userEmail, password, S2KCOUNT);
        }

        public static PgpKeyRingGenerator generateKeyRingGenerator(string userEmail, char[] password, int s2kcount)
        {
            RsaKeyPairGenerator kpg = new RsaKeyPairGenerator();

            kpg.Init(new RsaKeyGenerationParameters(BigInteger.ValueOf(0x10001), new SecureRandom(), KEYLENGTH, CERTAINTY));
            
            DateTime dtNowUtc = DateTime.UtcNow;

            // Create master signing key
            PgpKeyPair rsaKpSign = new PgpKeyPair(PublicKeyAlgorithmTag.RsaSign, kpg.GenerateKeyPair(), dtNowUtc);

            // Create encryption subkey
            PgpKeyPair rsaKpEncrypt = new PgpKeyPair(PublicKeyAlgorithmTag.RsaEncrypt, kpg.GenerateKeyPair(), dtNowUtc);

            // Self-sign the id
            PgpSignatureSubpacketGenerator signHashGen = new PgpSignatureSubpacketGenerator();

            // Add metadata on the signature
            signHashGen.SetKeyFlags(false, PgpKeyFlags.CanSign | PgpKeyFlags.CanCertify);
            signHashGen.SetPreferredSymmetricAlgorithms(false, new int[] { (int)SymmetricKeyAlgorithmTag.Aes256, 
                (int)SymmetricKeyAlgorithmTag.Aes192, (int)SymmetricKeyAlgorithmTag.Aes128, (int)SymmetricKeyAlgorithmTag.Blowfish });
            signHashGen.SetPreferredHashAlgorithms(false, new int[] { (int)HashAlgorithmTag.Sha512,
                            (int)HashAlgorithmTag.Sha384, (int)HashAlgorithmTag.Sha256, (int)HashAlgorithmTag.Sha224, 
                            (int)HashAlgorithmTag.RipeMD160, (int)HashAlgorithmTag.Tiger192 });
            signHashGen.SetTrust(false, 2, 255);

            PgpSignatureSubpacketVector signSubpktVector = signHashGen.Generate();
            
            
            // Create a signature on the encryption subkey
            PgpSignatureSubpacketGenerator encryptHashGen = new PgpSignatureSubpacketGenerator();

            encryptHashGen.SetKeyFlags(false, PgpKeyFlags.CanEncryptCommunications | PgpKeyFlags.CanEncryptStorage);

            PgpKeyRingGenerator keyRingGen = new PgpKeyRingGenerator(
                PgpSignature.DefaultCertification, rsaKpSign, userEmail, 
                SymmetricKeyAlgorithmTag.Aes256, password, false, signHashGen.Generate(), null, new SecureRandom());

            keyRingGen.AddSubKey(rsaKpEncrypt, encryptHashGen.Generate(), null);

            return keyRingGen;
        }
    }
}
