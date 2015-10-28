using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEF.Contracts;

namespace MEFDemo.Controllers
{
    public class HomeController : Controller
    {
        private Person person { get; set; }

        public HomeController()
        {
            person = new Person
            {
                FirstName = "Steve",
                LastName = "Fabian"
            };

        }

        public ActionResult Index()
        {
            return View(person);
        }

        public ActionResult Submit(string method)
        {
            var m = person.ContactMethods.FirstOrDefault(x => x.Name == method);
            if (m != null)
            {
                ViewBag.Status = m.Contact("Testing");
            }

            return View("Index", person);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}