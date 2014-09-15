namespace ContactLib.EFContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactContext : DbContext
    {
        public ContactContext()
            : base("name=ContactContext")
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactDetails> ContactDetails { get; set; }
        public virtual DbSet<ContactSetting> ContactSetting { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactDetails)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactDetails>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ContactSetting>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<ContactSetting>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ContactSetting>()
                .HasMany(e => e.ContactDetails)
                .WithRequired(e => e.ContactSetting)
                .WillCascadeOnDelete(false);
        }
    }
}
