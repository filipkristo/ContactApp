using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPortableLib.DAL
{
    public interface IContactDAL : IDisposable
    {
        Task<List<ContactModel>> GetAllContacts();
        Task<List<ContactModel>> GetContacts(String filter);
        Task<ContactModel> GetContactById(Guid Id);
        Task SaveContact(ContactModel Model);
        Task DeleteContact(Guid Id);
    }
}
