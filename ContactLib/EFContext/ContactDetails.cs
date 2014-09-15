namespace ContactLib.EFContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactDetails
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public Guid ContactId { get; set; }

        public Guid ContactSettingId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual ContactSetting ContactSetting { get; set; }
    }
}
