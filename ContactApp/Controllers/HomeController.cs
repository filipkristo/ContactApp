using ContactLib.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            using( var context = new ContactContext())
            {
                var a = context.Contact.ToList();                
                var b = context.ContactDetails.ToList();
                var c = context.ContactSetting.ToList();
            }
            return View();
        }        

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult AllContacts()
        {
            return View();
        }

        public ActionResult NewContact(Nullable<Guid> Id)
        {
            return View();
        }
    }
}