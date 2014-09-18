using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public class ContactTagModel
    {
        public Guid Id { get; set; }
        
        public string Tag { get; set; }

        public Guid ContactId { get; set; }
        
    }
}
