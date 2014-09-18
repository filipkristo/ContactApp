using ContactLib.EFContext;
using ContactPortableLib.DAL;
using ContactPortableLib.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ContactLib.DAL
{
    public class ContactDAL : IContactDAL
    {
        private ContactContext Context { get; set; }

        public ContactDAL()
        {
            this.Context = new ContactContext();
        }

        public async Task<List<ContactModel>> GetAllContacts()
        {            
            var data = await Context.Contact.ToListAsync();
            return AutoMapper.Mapper.Map<List<ContactModel>>(data);            
        }

        public async Task<List<ContactModel>> GetContacts(String filter)
        {
            var data = await Context.Contact
                .Where(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)
                || x.ContactTag.Any(c => c.Tag.Contains(filter))).ToListAsync();
            return AutoMapper.Mapper.Map<List<ContactModel>>(data);
        }        

        public async Task<ContactModel> GetContactById(Guid Id)
        {            
            var data = await Context.Contact.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return AutoMapper.Mapper.Map<ContactModel>(data);         
        }

        public async Task SaveContact(ContactModel Model)
        {            
            var entity = AutoMapper.Mapper.Map<Contact>(Model);

            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();

                entity.ContactEmail.ToList().ForEach(x => x.Id = Guid.NewGuid());
                entity.ContactPhone.ToList().ForEach(x => x.Id = Guid.NewGuid());
                entity.ContactTag.ToList().ForEach(x => x.Id = Guid.NewGuid());

                Context.Contact.Add(entity);
            }
            else
            {                

                foreach (var item in entity.ContactPhone)
                {
                    if (item.Id == Guid.Empty)
                    {
                        item.Id = Guid.NewGuid();
                        Context.ContactPhone.Add(item);
                    }
                    else
                    {
                        var phoneEntry = Context.Entry(item);
                        phoneEntry.State = item.Id == Guid.Empty ? EntityState.Added : EntityState.Modified;
                    }
                }

                var deletedPhone = Context.ContactPhone.Where(x => x.ContactId == Model.Id).ToList()
                    .Where(x => !entity.ContactPhone.Select(t => t.Id).Contains(x.Id)).ToList();
                Context.ContactPhone.RemoveRange(deletedPhone);

                foreach (var item in entity.ContactEmail)
                {
                    if (item.Id == Guid.Empty)
                    {
                        item.Id = Guid.NewGuid();
                        Context.ContactEmail.Add(item);
                    }
                    else
                    {
                        var emailEntry = Context.Entry(item);
                        emailEntry.State = item.Id == Guid.Empty ? EntityState.Added : EntityState.Modified;
                    }
                }

                var deletedMail = Context.ContactEmail.Where(x => x.ContactId == Model.Id).ToList()
                    .Where(x => !entity.ContactEmail.Select(t => t.Id).Contains(x.Id)).ToList();
                Context.ContactEmail.RemoveRange(deletedMail);

                foreach (var item in entity.ContactTag)
                {
                    if (item.Id == Guid.Empty)
                    {
                        item.Id = Guid.NewGuid();
                        Context.ContactTag.Add(item);
                    }
                    else
                    {
                        var tagEntry = Context.Entry(item);
                        tagEntry.State = item.Id == Guid.Empty ? EntityState.Added : EntityState.Modified;
                    }
                }

                var deletedTag = Context.ContactTag.Where(x => x.ContactId == Model.Id).ToList()
                    .Where(x => !entity.ContactTag.Select(t => t.Id).Contains(x.Id)).ToList();
                Context.ContactTag.RemoveRange(deletedTag);

                var entry = Context.Entry(entity);
                entry.State = EntityState.Modified;                

            }

            await Context.SaveChangesAsync();         
        }

        public async Task DeleteContact(Guid Id)
        {            
            var entity = await Context.Contact.Where(x => x.Id == Id).FirstOrDefaultAsync();

            Context.ContactPhone.RemoveRange(entity.ContactPhone);
            Context.ContactEmail.RemoveRange(entity.ContactEmail);
            Context.ContactTag.RemoveRange(entity.ContactTag);

            Context.Contact.Remove(entity);

            await Context.SaveChangesAsync();         
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }
    }
}
