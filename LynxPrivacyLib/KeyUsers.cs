namespace LynxPrivacyLib
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    public partial class KeyUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KeyUserID { get; set; }

        public long KeyStoreID { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        [StringLength(20)]
        public string EncryptionType { get; set; }

        public int KeySize { get; set; }

        [StringLength(20)]
        public string HashFunction { get; set; }

        [StringLength(20)]
        public string CompressionType { get; set; }

        public virtual KeyStores KeyStores { get; set; }

    }
}
