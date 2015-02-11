using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Security;


namespace LynxPrivacyLib
{
    public class PgpEncryptString
    {
        private RetrievePgpKeys m_encryptionKeys;
        private AlgorithmAgreement m_algorithmsAgreed;
        private const int BUFFER_SIZE = 0x10000;


        public PgpEncryptString(RetrievePgpKeys keys)
        {
            if (keys == null)
                throw new ArgumentNullException("keys");

            m_encryptionKeys = keys;
            m_algorithmsAgreed = new AlgorithmAgreement(keys.PublicKeys);
        }

        public string EncryptAndSign(string unencryptedString, bool armour = false, bool signOnly = false)
        {
            if (string.IsNullOrEmpty(unencryptedString))
                throw new ArgumentNullException("unencryptedString");

            if (signOnly) {
                m_algorithmsAgreed.AgreedSymmetricKeyAlgorithm = SymmetricKeyAlgorithmTag.Null;
                m_algorithmsAgreed.AgreedCompressionAlgorithm = CompressionAlgorithmTag.Uncompressed;
            }
            byte[] unencryptedBytes = Encoding.UTF8.GetBytes(unencryptedString);
            return EncryptAndSign(unencryptedBytes, armour);
        }

        private string EncryptAndSign(byte[] unencryptedBytes, bool armour)
        {
            string returnStr = string.Empty;
            Stream readStream = new MemoryStream();
            MemoryStream armourStream = new MemoryStream();
            if (armour)
                readStream = new ArmoredOutputStream(armourStream);
            using (Stream encryptedOut = ChainEncryptedOut(readStream)) {
                using (Stream compressedOut = ChainCompressedOut(encryptedOut, m_algorithmsAgreed.AgreedCompressionAlgorithm)) {
                    PgpSignatureGenerator sigGenerator = InitSignatureGenerator(compressedOut);
                    using (Stream literalOut = ChainLiteralOut(compressedOut, unencryptedBytes)) {
                        WriteOutputAndSign(compressedOut, literalOut, unencryptedBytes, sigGenerator);
                    }
                }
                if (!armour) {
                    StreamReader reader = new StreamReader(armourStream);
                    returnStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            if (armour) {
                readStream.Close();
                char[] buffer = new char[BUFFER_SIZE];
                StreamReader reader = new StreamReader(armourStream);
                armourStream.Position = 0;
                returnStr = reader.ReadToEnd();
                reader.Close();
            }


            return returnStr;
        }

        private static void WriteOutputAndSign(Stream compressedOut, Stream literalOut, byte[] unencryptedBytes, PgpSignatureGenerator sigGenerator)
        {
            literalOut.Write(unencryptedBytes, 0, unencryptedBytes.Length);
            sigGenerator.Update(unencryptedBytes, 0, unencryptedBytes.Length);
            sigGenerator.Generate().Encode(compressedOut);
        }

        private Stream ChainEncryptedOut(Stream outputStream)
        {
            if (m_algorithmsAgreed.AgreedSymmetricKeyAlgorithm != SymmetricKeyAlgorithmTag.Null) {
                PgpEncryptedDataGenerator encryptedDataGenerator =
                    new PgpEncryptedDataGenerator(m_algorithmsAgreed.AgreedSymmetricKeyAlgorithm,
                        new SecureRandom());

                foreach (PgpPublicKey publicKey in m_encryptionKeys.PublicKeys) {
                    encryptedDataGenerator.AddMethod(publicKey);
                }
                return encryptedDataGenerator.Open(outputStream, new byte[BUFFER_SIZE]);
            } else
                return outputStream;   //no encryption, just pass-thru for sign only
        }

        private static Stream ChainCompressedOut(Stream encryptedOut, CompressionAlgorithmTag compAgreed)
        {
            PgpCompressedDataGenerator pgpCompDataGenerator = new PgpCompressedDataGenerator(compAgreed);

            return pgpCompDataGenerator.Open(encryptedOut);
        }

        private static Stream ChainLiteralOut(Stream compressedOut, byte[] clearData)
        {
            string fileName = "clip";
            PgpLiteralDataGenerator literalData = new PgpLiteralDataGenerator();

            return literalData.Open(compressedOut, PgpLiteralData.Binary, fileName, clearData.Length, DateTime.UtcNow);
        }

        private PgpSignatureGenerator InitSignatureGenerator(Stream compressedOut)
        {
            const bool IsCritical = false;
            const bool IsNested = false;

            PublicKeyAlgorithmTag tag = m_encryptionKeys.SecretKey.PublicKey.Algorithm;

            PgpSignatureGenerator pgpSigGenerator = new PgpSignatureGenerator(tag, m_algorithmsAgreed.AgreedHashAlgorithm);

            pgpSigGenerator.InitSign(PgpSignature.BinaryDocument, m_encryptionKeys.PrivateKey);

            foreach (string userId in m_encryptionKeys.SecretKey.PublicKey.GetUserIds()) {
                PgpSignatureSubpacketGenerator subPcktGenerator = new PgpSignatureSubpacketGenerator();
                subPcktGenerator.SetSignerUserId(IsCritical, userId);
                pgpSigGenerator.SetHashedSubpackets(subPcktGenerator.Generate());

                break;
            }
            pgpSigGenerator.GenerateOnePassVersion(IsNested).Encode(compressedOut);

            return pgpSigGenerator;
        }
    }
}
