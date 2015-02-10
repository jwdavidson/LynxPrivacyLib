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
    public class PGPDecryptClipboard
    {
        public static byte[] Decrypt(string encryptedText, RetrievePgpKeys keys)
        {
            AlgorithmAgreement m_algorithmsAgreed = new AlgorithmAgreement(keys.PublicKeys);
            byte[] encryptedBytes = Encoding.UTF8.GetBytes(encryptedText);
            return Decrypt(encryptedBytes, keys, m_algorithmsAgreed);
        }

        public static byte[] Decrypt(byte[] encryptedData, RetrievePgpKeys keys, AlgorithmAgreement agreed)
        {
            Stream inputStream = new MemoryStream(encryptedData);
            inputStream = PgpUtilities.GetDecoderStream(inputStream);

            PgpObjectFactory pgpObjFactory = new PgpObjectFactory(inputStream);
            PgpEncryptedDataList enc;
            PgpObject pgpObj = pgpObjFactory.NextPgpObject();

            if (pgpObj is PgpEncryptedDataList)
                enc = (PgpEncryptedDataList)pgpObj;
            else
                enc = (PgpEncryptedDataList)pgpObjFactory.NextPgpObject();

            PgpPrivateKey privKey = keys.PrivateKey;
            PgpPublicKeyEncryptedData pbe = null;

            foreach (PgpPublicKeyEncryptedData pked in enc.GetEncryptedDataObjects()) {
                if (privKey != null) {
                    pbe = pked;
                    break;
                }
            }
            PgpOnePassSignatureList onePassSigList = null;
            Stream clear = pbe.GetDataStream(privKey);
            PgpObjectFactory plainFactory = new PgpObjectFactory(clear);
            PgpObject message = plainFactory.NextPgpObject();
            if (message is PgpCompressedData) {
                PgpCompressedData compressedData = (PgpCompressedData)message;
                Stream compDataIn = compressedData.GetDataStream();
                PgpObjectFactory objectFactory = new PgpObjectFactory(compDataIn);
                message = objectFactory.NextPgpObject();
                if (message is PgpOnePassSignatureList) {
                    onePassSigList = (message as PgpOnePassSignatureList);

                    message = objectFactory.NextPgpObject();
                }
                compDataIn.Close();
            } else {
                if (message is PgpOnePassSignatureList) {
                    onePassSigList = (message as PgpOnePassSignatureList);
                }
                message = plainFactory.NextPgpObject();

            }

            PgpLiteralData literalData = (PgpLiteralData)message;
            Stream unc = literalData.GetInputStream();

            byte[] returnBytes = Org.BouncyCastle.Utilities.IO.Streams.ReadAll(unc);

            PgpSignatureList signatureList = (PgpSignatureList)plainFactory.NextPgpObject();

            VerifySignature(onePassSigList, signatureList, keys.SecretKey.PublicKey, returnBytes);

            unc.Close();
            clear.Close();
            inputStream.Close();

            return returnBytes;
        }

        private static void VerifySignature(PgpOnePassSignatureList onePassSigList, PgpSignatureList signatureList, PgpPublicKey pubKey, byte[] original)
        {
            PgpOnePassSignature ops = onePassSigList[0];

            ops.InitVerify(pubKey);
            ops.Update(original);

            PgpSignatureList p3 = signatureList;
            PgpSignature sig = p3[0];

            if (sig.KeyId != pubKey.KeyId) {
                throw new PgpException("key id mismatch in signature.");
            }

            if (!ops.Verify(sig)){
                throw new PgpException("Failed generated signature check.");
            }

            sig.InitVerify(pubKey);

            for (int i = 0; i <= original.Length; i++) {
                sig.Update(original[i]);
            }

            sig.Update(original);

            if (!sig.Verify()) {
                throw new PgpException("Failed generated signature check against original data.");
            }
        }
    }
}
