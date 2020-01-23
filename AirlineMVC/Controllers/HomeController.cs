using AirlineMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlineMVC.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult MyAccount()
        {
            var email = User.Identity.Name;
    
            Customer customer = db.Customers.FirstOrDefault(c => c.EmailAddress == email);

            if (customer == null)
            {
                return HttpNotFound();
            }

            MyAccount account = new MyAccount();
            account.Customer = customer;

            Address address = db.Addresses.Find(customer.AddressID);
            account.Address = address;
            customer.Address = address;

            return View(customer);
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}