using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public class ContactPhoneModel
    {
        public Guid Id { get; set; }
        
        public string Phone { get; set; }

        public Guid ContactId { get; set; }        
    }
}
