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
using System.Diagnostics;

namespace LynxPrivacyLib
{

    public enum SignatureOperation {
        AddUserId,
        RevokeKey,
        SetKeyExpiry,
        CertifyKey
    }
    public static class PgpPublicKeyModifySignatures
    {
        public static void AddSignature(PgpPublicKey key, KeyStoreDB keyDb, string keyExportName, PgpSecretKey secKey, char[] passPhrase, 
            SignatureOperation op, DateTime expiryDate, PgpSignature certLevel = null, string userId = "")
        {
            string fileData = string.Empty;
            bool useTemp = true;

            if (key == null)
                throw new ArgumentNullException("key");
            if (keyDb == null)
                throw new ArgumentNullException("keyDb");
            if (!Enum.IsDefined(typeof(SignatureOperation), op))
                throw new ArgumentOutOfRangeException(string.Format("op: {0}", op));

            AlgorithmAgreement algorithms = new AlgorithmAgreement(new List<PgpPublicKey>() { key });
            PgpPrivateKey privateKey = secKey.ExtractPrivateKey(passPhrase);
            PgpSignatureGenerator sigGen = new PgpSignatureGenerator(key.Algorithm, algorithms.AgreedHashAlgorithm);

            switch (op) {
                case SignatureOperation.AddUserId:
                    break;
                case SignatureOperation.RevokeKey:
                    MemoryStream mStream = new MemoryStream();
                    using (ArmoredOutputStream outArmour = new ArmoredOutputStream(mStream)) {
                        outArmour.SetHeader("Version", "Lynx Privacy");
                        sigGen.InitSign(PgpSignature.KeyRevocation, privateKey);
                        PgpSignature sig = sigGen.GenerateCertification(secKey.PublicKey);
                        PgpPublicKey.AddCertification(secKey.PublicKey, sig);
                        sig.InitVerify(secKey.PublicKey);
                        if (!sig.VerifyCertification(secKey.PublicKey)) {
                            throw new PgpException("revocation verification failed.");
                        }
                        sig.Encode(outArmour);
                        outArmour.Close();
                    }
                    mStream.Position = 0;
                    StreamReader srdr = new StreamReader(mStream);
                    string armour = srdr.ReadToEnd();
                    string outstr = armour.Replace("BEGIN PGP SIGNATURE", "BEGIN PGP PUBLIC KEY BLOCK")
                            .Replace("END PGP SIGNATURE", "END PGP PUBLIC KEY BLOCK");
                    mStream.Close();
                    if (string.IsNullOrEmpty(keyExportName)) {
                        useTemp = true;
                        string tempPath = Path.GetTempPath();
                        keyExportName = Path.Combine(tempPath, Guid.NewGuid().ToString() + ".tmppgp");
                    }
                    File.WriteAllText(keyExportName, outstr);
                    keyExportName = "";
                    //Debug.Assert(secKey.PublicKey.IsRevoked() == true);
                    break;
                case SignatureOperation.SetKeyExpiry:
                    break;
                case SignatureOperation.CertifyKey:
                    break;
                default:
                    break;
            }


            if (secKey.PublicKey != null) {
                if (string.IsNullOrEmpty(keyExportName)) {
                    useTemp = true;
                    string tempPath = Path.GetTempPath();
                    keyExportName = Path.Combine(tempPath, Guid.NewGuid().ToString() + ".tmppgp");
                }
                ExportKey expKey = new ExportKey(keyDb);
                expKey.UpdateDbSecretKey(secKey, keyExportName);
                if (useTemp) {
                    //File.Delete(keyExportName);
                }
            }
        }

        public static void AddCertification(PgpPublicKey key, KeyStoreDB keyDb, PgpSecretKey secKey, char[] passPhrase){

        }

    }
}
