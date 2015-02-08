using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;

namespace LynxPrivacyLib
{
    public static class PgpEncryptClipboard
    {

        public static byte[] encrypt(string clearText, RetrievePgpKeys keys, bool armour)
        {
            byte[] clearTextBytes = Encoding.UTF8.GetBytes(clearText);
            return encrypt(clearTextBytes, keys, armour);
        }

        public static byte[] encrypt(byte[] clearText, RetrievePgpKeys keys, bool armour)
        {

            AlgorithmAgreement algorithms = new AlgorithmAgreement(keys.PublicKeys);
            SymmetricKeyAlgorithmTag symmetricKeyTag = algorithms.AgreedSymmetricKeyAlgorithm;
            CompressionAlgorithmTag compressionTag = algorithms.AgreedCompressionAlgorithm;

            armour = true;

            string fileName = PgpLiteralData.Console;

            byte[] compressedData = Compress(clearText, fileName, compressionTag);

            using (MemoryStream bOut = new MemoryStream()) {
                Stream output = bOut;
                if (armour)
                    output = new ArmoredOutputStream(output);

                PgpEncryptedDataGenerator encGen = new PgpEncryptedDataGenerator(symmetricKeyTag, new SecureRandom());
                foreach (PgpPublicKey key in keys.PublicKeys){
                    if (key.IsEncryptionKey) {
                        encGen.AddMethod(key);
                    }
                }
                using (Stream encOut = encGen.Open(output, compressedData.Length)) {
                    encOut.Write(compressedData, 0, compressedData.Length);
                    encOut.Close();

                    if (armour)
                        output.Close();

                    return bOut.ToArray();
                }
            }

        }

        private static byte[] Compress(byte[] clearData, string fileName, CompressionAlgorithmTag algorithm)
        {
            using (MemoryStream bOut = new MemoryStream()) {
                PgpCompressedDataGenerator compressedData = new PgpCompressedDataGenerator(algorithm);
                using (Stream cos = compressedData.Open(bOut)) {
                    PgpLiteralDataGenerator literalData = new PgpLiteralDataGenerator();
                    using (Stream pOut = literalData.Open(cos, PgpLiteralData.Binary, fileName, clearData.Length, DateTime.UtcNow)) {
                        pOut.Write(clearData, 0, clearData.Length);
                        pOut.Close();
                        compressedData.Close();
                        return bOut.ToArray();
                    }
                }
            }
        }
    }
}
