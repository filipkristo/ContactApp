using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public interface IContactSetting
    {
        Guid Id { get; set; }
        String Key { get; set; }
        String Value { get; set; }
        ICollection<IContactDetails> ContactDetails { get; set; }
    }
}
