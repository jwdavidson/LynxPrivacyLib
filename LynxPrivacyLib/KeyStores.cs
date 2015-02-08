namespace LynxPrivacyLib
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyStores
    {
        public KeyStores()
        {
            KeyUsers = new HashSet<KeyUsers>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long KeyStoreID { get; set; }

        [Required]
        [StringLength(20)]
        public string KeyType { get; set; }

        public DateTime CreationTime { get; set; }

        public int ValidDays { get; set; }

        public bool IsMasterKey { get; set; }

        public bool IsSigningKey { get; set; }

        public bool IsEncryptionKey { get; set; }

        [MaxLength(20)]
        public byte[] Fingerprint { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ArmouredKeyFile { get; set; }
        public bool IsRevoked { get; set; }
        [MaxLength(20)]
        public string OwnerTrust { get; set; }

        public virtual ICollection<KeyUsers> KeyUsers { get; set; }
    }
}
