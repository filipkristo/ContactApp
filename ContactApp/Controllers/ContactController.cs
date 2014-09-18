using ContactLib.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;
using ContactPortableLib.DAL;
using ContactPortableLib.ObjectModel;
using ContactLib.DAL;

namespace ContactApp.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        private IContactDAL DAL;

        public ContactController(IContactDAL ContactDAL)
        {
            this.DAL = ContactDAL;    
        }

        [Route("Contacts")]
        public async Task<List<ContactModel>> GetContacts(String filter = "")
        {
            if (String.IsNullOrWhiteSpace(filter))
                return await DAL.GetAllContacts();
            else
                return await DAL.GetContacts(filter);
        }

        [Route("Contact")]
        public async Task<ContactModel> GetContact(Guid Id)
        {            
            return await DAL.GetContactById(Id);
        }

        [Route("SaveContact")]
        public async Task<IHttpActionResult> SaveContact(ContactModel Model)
        {            
            await DAL.SaveContact(Model);

            return Ok();
        }

        [Route("DeleteContact")]
        public async Task<IHttpActionResult> DeleteContact(Guid Id)
        {            
            await DAL.DeleteContact(Id);

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            DAL.Dispose();
        }
    }
}
