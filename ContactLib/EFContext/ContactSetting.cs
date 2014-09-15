namespace ContactLib.EFContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactSetting")]
    public partial class ContactSetting
    {
        public ContactSetting()
        {
            ContactDetails = new HashSet<ContactDetails>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Key { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public virtual ICollection<ContactDetails> ContactDetails { get; set; }
    }
}
