namespace LynxPrivacyLib
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KeyStoreDB : DbContext
    {
        public KeyStoreDB()
            : base("name=KeyStoreDB")
        {
        }

        public virtual DbSet<KeyStores> KeyStores { get; set; }
        public virtual DbSet<KeyUsers> KeyUsers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<KeyStores>()
        //        .HasMany(e => e.KeyUsers)
        //        .WithRequired(e => e.KeyStores)
        //        .WillCascadeOnDelete(true);
        //}
    }
}
