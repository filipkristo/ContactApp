using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib.ObjectModel
{
    public class Contact : IContact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public virtual ICollection<IContactDetails> Phones { get; set; }

        public virtual ICollection<IContactDetails> Emails { get; set; }

        public virtual ICollection<IContactDetails> Tags { get; set; }        
    }
}
