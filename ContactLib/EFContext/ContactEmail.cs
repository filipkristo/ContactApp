namespace ContactLib.EFContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmail")]
    public partial class ContactEmail
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public Guid ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
