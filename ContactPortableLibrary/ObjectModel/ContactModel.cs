using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public class ContactModel 
    {
        public ContactModel()
        {
            ContactEmail = new List<ContactEmailModel>();
            ContactPhone = new List<ContactPhoneModel>();
            ContactTag = new List<ContactTagModel>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public List<ContactEmailModel> ContactEmail { get; set; }

        public List<ContactPhoneModel> ContactPhone { get; set; }

        public List<ContactTagModel> ContactTag { get; set; }
    }
}
