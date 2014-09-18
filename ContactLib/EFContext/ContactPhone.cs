namespace ContactLib.EFContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactPhone")]
    public partial class ContactPhone
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

        public Guid ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
