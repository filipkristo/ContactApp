using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib.ObjectModel
{
    public class ContactSetting : IContactSetting
    {
        public Guid Id { get; set; }
        public String Key { get; set; }
        public String Value { get; set; }                
    }
}
