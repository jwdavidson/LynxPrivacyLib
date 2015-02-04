using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace LynxPrivacyLib
{
    public static class PgpEncryptClipboard
    {

        private const int BUFFER_SIZE = 0x10000;

        private static void encrypt(string clearText, RetrievePgpKeys keys)
        {

            AlgorithmAgreement algorithms = new AlgorithmAgreement(keys.PublicKeys);
            SymmetricKeyAlgorithmTag symmetricKeyTag = algorithms.AgreedSymmetricKeyAlgorithm;
            HashAlgorithmTag hashTag = algorithms.AgreedHashAlgorithm;
            CompressionAlgorithmTag compressionTag = algorithms.AgreedCompressionAlgorithm;

            bool armour = true;
            bool withIntegrityCheck = true;
            byte[] clearTextBytes = Encoding.UTF8.GetBytes(clearText);

            


        }
    }
}
