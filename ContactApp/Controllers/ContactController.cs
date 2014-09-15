using ContactLib.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;

namespace ContactApp.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        [Route("Contacts")]
        public async Task<Object> GetContacts()
        {
            try
            {
                using(var db = new ContactContext())
                {                    
                    return await db.Contact.Select(x => new { FirstName = x.FirstName, LastName = x.LastName, Address = x.Address, City = x.City, Country = x.Country, PostCode = x.PostCode}).ToListAsync();                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
