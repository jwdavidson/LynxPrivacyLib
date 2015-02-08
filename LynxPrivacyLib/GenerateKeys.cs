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



        public static void GenerateKeyRing(string userEmail, char[] password, string keyStorePath)
        {

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

            email = email.Replace(".", "_");

            IAsymmetricCipherKeyPairGenerator kpg = GeneratorUtilities.GetKeyPairGenerator("RSA");

            kpg.Init(new RsaKeyGenerationParameters(
                BigInteger.ValueOf(P_EXPONENT), new SecureRandom(), KEYLENGTH, 25));

            AsymmetricCipherKeyPair kp = kpg.GenerateKeyPair();

            Stream out1, out2;

            out1 = File.Create(Path.Combine(keyStorePath, email + "_secret.asc"));
            out2 = File.Create(Path.Combine(keyStorePath, email + "_public.asc"));

            ExportKeyPair(out1, out2, kp.Public, kp.Private, userEmail, password, true);

            out1.Close();
            out2.Close();

        }
        private static void ExportKeyPair(
            Stream secretOut,
            Stream publicOut,
            AsymmetricKeyParameter publicKey,
            AsymmetricKeyParameter privateKey,
            string identity,
            char[] passPhrase,
            bool armor)
        {
            if (armor) {
                secretOut = new ArmoredOutputStream(secretOut);
            }

            PgpSignatureSubpacketGenerator signHashGen = new PgpSignatureSubpacketGenerator();

            signHashGen.SetKeyFlags(false, PgpKeyFlags.CanSign | PgpKeyFlags.CanCertify | PgpKeyFlags.CanEncryptCommunications | PgpKeyFlags.CanEncryptStorage);
            signHashGen.SetPreferredSymmetricAlgorithms(false, new int[] { (int)SymmetricKeyAlgorithmTag.Aes256, 
                (int)SymmetricKeyAlgorithmTag.Aes192, (int)SymmetricKeyAlgorithmTag.Aes128, (int)SymmetricKeyAlgorithmTag.Blowfish });
            signHashGen.SetPreferredHashAlgorithms(false, new int[] { (int)HashAlgorithmTag.Sha512,
                            (int)HashAlgorithmTag.Sha384, (int)HashAlgorithmTag.Sha256, (int)HashAlgorithmTag.Sha224, 
                            (int)HashAlgorithmTag.RipeMD160, (int)HashAlgorithmTag.Tiger192 });
            signHashGen.SetPreferredCompressionAlgorithms(false, new int[] {(int)CompressionAlgorithmTag.ZLib, 
                                                (int)CompressionAlgorithmTag.BZip2, (int)CompressionAlgorithmTag.Zip});
            signHashGen.SetTrust(false, 8, 255);

            PgpSignatureSubpacketVector signSubpktVector = signHashGen.Generate();


            PgpSecretKey secretKey = new PgpSecretKey(
                PgpSignature.PositiveCertification,
                PublicKeyAlgorithmTag.RsaGeneral,
                publicKey,
                privateKey,
                DateTime.UtcNow,
                identity,
                SymmetricKeyAlgorithmTag.Aes256,
                passPhrase,
                signSubpktVector, //null,
                null,
                new SecureRandom()
                );

            secretKey.Encode(secretOut);

            if (armor) {
                secretOut.Close();
                publicOut = new ArmoredOutputStream(publicOut);
            }

            PgpPublicKey key = secretKey.PublicKey;

            key.Encode(publicOut);

            if (armor) {
                publicOut.Close();
            }
        }
    }
}
