using AutoMapper;
using ContactLib.EFContext;
using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib.AutoMapperSetup
{
    public static class AutoMapperSetup
    {
        public static void SetupAll()
        {
            Mapper.CreateMap<ContactModel, Contact>();
            Mapper.CreateMap<Contact, ContactModel>();

            Mapper.CreateMap<ContactPhoneModel, ContactPhone>();
            Mapper.CreateMap<ContactPhone, ContactPhoneModel>();            

            Mapper.CreateMap<ContactEmailModel, ContactEmail>();
            Mapper.CreateMap<ContactEmail, ContactEmailModel>();

            Mapper.CreateMap<ContactTagModel, ContactTag>();
            Mapper.CreateMap<ContactTag, ContactTagModel>();
        }
    }
}
