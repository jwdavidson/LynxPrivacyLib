using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxPrivacyLib
{
    public static class UpdateOwnerTrust
    {
        static string pubKeyLevels = "unknownnevermarginalfull";
        static string secKeyLevel = "ultimate";
        public static bool Update(KeyStoreDB keyStoreDb, long keyId, string trust)
        {
            if (keyStoreDb == null)
                throw new ArgumentNullException("keyStoreDb");
            if (keyId == 0)
                throw new ArgumentOutOfRangeException("keyId");
            if (string.IsNullOrEmpty(trust))
                throw new ArgumentNullException("trust");


            KeyStores updRow = keyStoreDb.KeyStores.Find(keyId);
            switch (updRow.KeyType) {
                case "Public":
                    if (pubKeyLevels.Contains(trust.ToLower()))
                        updRow.OwnerTrust = trust;
                    else
                        updRow.OwnerTrust = string.Empty;
                    break;
                case "Secret":
                    if (secKeyLevel.Equals(trust.ToLower()))
                        updRow.OwnerTrust = trust;
                    else 
                        updRow.OwnerTrust = trust;
                    break;
                default:
                    break;
            }
            keyStoreDb.SaveChanges();

            return true;
        }
    }
}
