using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.ObjectModel
{
    public interface IContactDetails
    {
        Guid Id { get; set; }        
        String Value { get; set; }
        IContactSetting ContactSetting { get; set; }
        IContact Contact { get; set; }
        Guid ContactSettingId { get; set; }
        Guid ContactId { get; set; }
    }
}
