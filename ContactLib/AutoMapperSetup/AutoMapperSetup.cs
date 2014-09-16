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
        }
    }
}
