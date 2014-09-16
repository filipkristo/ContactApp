using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public class ContactDetailsModel 
    {
        public Guid Id { get; set; }
        
        public string Value { get; set; }

        public Guid ContactId { get; set; }

        public Guid ContactSettingId { get; set; }        

        public ContactSettingModel ContactSetting { get; set; }
    }
}
