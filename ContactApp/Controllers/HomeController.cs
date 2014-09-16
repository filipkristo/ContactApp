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