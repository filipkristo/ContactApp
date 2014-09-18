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
        public virtual DbSet<ContactEmail> ContactEmail { get; set; }
        public virtual DbSet<ContactPhone> ContactPhone { get; set; }
        public virtual DbSet<ContactTag> ContactTag { get; set; }

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
                .HasMany(e => e.ContactEmail)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactPhone)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactTag)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactEmail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ContactPhone>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ContactTag>()
                .Property(e => e.Tag)
                .IsUnicode(false);
        }
    }
}
