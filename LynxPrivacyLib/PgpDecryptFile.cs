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
    public class PgpDecryptFile
    {
        public string m_encryptedFilePath;
        public RetrievePgpKeys m_retrievePgpKeys;
        public string m_outputPath;

        public PgpDecryptFile(string encryptedFilePath, RetrievePgpKeys keys, string outputPath)
        {
            m_encryptedFilePath = encryptedFilePath;
            m_retrievePgpKeys = keys;
            m_outputPath = outputPath;
        }

        public void Decrypt(Stream input, string outputPath)
        {
            input = PgpUtilities.GetDecoderStream(input);

            try {
                PgpObjectFactory pgpObjFactory = new PgpObjectFactory(input);
                PgpEncryptedDataList enc;
                PgpObject obj = pgpObjFactory.NextPgpObject();
                if (obj is PgpEncryptedDataList)
                    enc = (PgpEncryptedDataList)obj;
                else
                    enc = (PgpEncryptedDataList)pgpObjFactory.NextPgpObject();

                PgpPrivateKey privKey = m_retrievePgpKeys.PrivateKey;
                PgpPublicKeyEncryptedData pbe = null;

                foreach (PgpPublicKeyEncryptedData pked in enc.GetEncryptedDataObjects()) {
                    if (privKey != null) {
                        pbe = pked;
                        break;
                    }
                }
                Stream clear = pbe.GetDataStream(privKey);
                PgpObjectFactory plainFactory = new PgpObjectFactory(clear);
                PgpObject message = plainFactory.NextPgpObject();
                if (message is PgpCompressedData) {
                    PgpCompressedData compressedData = (PgpCompressedData)message;
                    Stream compDataIn = compressedData.GetDataStream();
                    PgpObjectFactory objectFactory = new PgpObjectFactory(compDataIn);
                    message = objectFactory.NextPgpObject();
                    if (message is PgpOnePassSignatureList) {
                        message = objectFactory.NextPgpObject();
                    }
                    compDataIn.Close();
                } else
                    message = plainFactory.NextPgpObject();

                PgpLiteralData literalData = (PgpLiteralData)message;
                Stream output = File.Create(Path.Combine(outputPath, literalData.FileName));
                Stream uncompressData = literalData.GetInputStream();
                Org.BouncyCastle.Utilities.IO.Streams.PipeAll(uncompressData, output);

                clear.Close();
                uncompressData.Close();
                output.Close();

            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }
    }
}
