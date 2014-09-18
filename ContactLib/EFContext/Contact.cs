namespace ContactLib.EFContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public Contact()
        {
            ContactEmail = new HashSet<ContactEmail>();
            ContactPhone = new HashSet<ContactPhone>();
            ContactTag = new HashSet<ContactTag>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string PostCode { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public virtual ICollection<ContactEmail> ContactEmail { get; set; }

        public virtual ICollection<ContactPhone> ContactPhone { get; set; }

        public virtual ICollection<ContactTag> ContactTag { get; set; }
    }
}
