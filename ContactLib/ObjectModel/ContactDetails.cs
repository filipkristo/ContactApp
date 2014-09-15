using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib.ObjectModel
{
    public class ContactDetails : IContactDetails
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public Guid ContactId { get; set; }

        public Guid ContactSettingId { get; set; }        

        public virtual IContactSetting ContactSetting { get; set; }
    }
}
