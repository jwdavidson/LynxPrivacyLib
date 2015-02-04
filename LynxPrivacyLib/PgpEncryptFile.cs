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
    public class PgpEncryptFile
    {
        private RetrievePgpKeys m_encryptionKeys;
        private AlgorithmAgreement m_algorithmsAgreed;
        private const int BUFFER_SIZE = 0x10000;


        public PgpEncryptFile(RetrievePgpKeys keys)
        {
            if (keys == null)
                throw new ArgumentNullException("keys");

            m_encryptionKeys = keys;
            m_algorithmsAgreed = new AlgorithmAgreement(keys.PublicKeys);
        }

        public void EncryptAndSign(Stream outputStream, FileInfo unencryptedFileInfo)
        {
            if (outputStream == null)
                throw new ArgumentNullException("outputStream");
            if (unencryptedFileInfo == null)
                throw new ArgumentNullException("unencryptedFileInfo");
            if (!File.Exists(unencryptedFileInfo.FullName))
                throw new FileNotFoundException(unencryptedFileInfo.FullName);

            using (Stream encryptedOut = ChainEncryptedOut(outputStream)) {
                using (Stream compressedOut = ChainCompressedOut(encryptedOut, m_algorithmsAgreed.AgreedCompressionAlgorithm)) {
                    PgpSignatureGenerator sigGenerator = InitSignatureGenerator(compressedOut);
                    using (Stream literalOut = ChainLiteralOut(compressedOut, unencryptedFileInfo)) {
                        using (FileStream inputFile = unencryptedFileInfo.OpenRead()) {
                            WriteOutputAndSign(compressedOut, literalOut, inputFile, sigGenerator);
                        }
                    }
                }

            }
        }

        private static void WriteOutputAndSign(Stream compressedOut, Stream literalOut, FileStream inputFile, PgpSignatureGenerator sigGenerator)
        {
            int length = 0;
            byte[] buf = new byte[BUFFER_SIZE];
            while ((length = inputFile.Read(buf, 0, buf.Length)) > 0) {
                literalOut.Write(buf, 0, length);
                sigGenerator.Update(buf, 0, length);
            }
            sigGenerator.Generate().Encode(compressedOut);
        }

        private Stream ChainEncryptedOut(Stream outputStream)
        {
            PgpEncryptedDataGenerator encryptedDataGenerator =
                new PgpEncryptedDataGenerator(m_algorithmsAgreed.AgreedSymmetricKeyAlgorithm,
                    new SecureRandom());

            foreach (PgpPublicKey publicKey in m_encryptionKeys.PublicKeys) {
                encryptedDataGenerator.AddMethod(publicKey);
            }
            return encryptedDataGenerator.Open(outputStream, new byte[BUFFER_SIZE]);
        }

        private static Stream ChainCompressedOut(Stream encryptedOut, CompressionAlgorithmTag compAgreed)
        {
            PgpCompressedDataGenerator pgpCompDataGenerator = new PgpCompressedDataGenerator(compAgreed);

            return pgpCompDataGenerator.Open(encryptedOut);
        }

        private static Stream ChainLiteralOut(Stream compressedOut, FileInfo file)
        {
            PgpLiteralDataGenerator pgpLiteralDataGenerator = new PgpLiteralDataGenerator();

            return pgpLiteralDataGenerator.Open(compressedOut, PgpLiteralData.Binary, file);
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
