using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public interface IContact
    {
        Guid Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String Address { get; set; }
        String PostCode { get; set; }
        String City { get; set; }
        String Country { get; set; }
        ICollection<IContactDetails> Phones { get; set; }
        ICollection<IContactDetails> Emails { get; set; }
        ICollection<IContactDetails> Tags { get; set; }        
    }
}
