using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="Juan Amilcar"},
                new Customer{Id=2, Name="Gustavo Lopez"},
                new Customer{Id=3, Name="Bad Bunny"}


            };
            var customer = new Customer { Customers = customers };
            return View(customer);
        }
        public ActionResult Customer(int id)
        {
            switch (id)
            {
                case 1:
                    return View(new Customer { Id=1, Name="Juan Amilcar"});
                case 2:
                    return View(new Customer { Id=2, Name="Gustavo Lopez"});
                case 3:
                    return View(new Customer { Id = 3, Name = "Bad Bunny" });


                default:
                    return HttpNotFound();
            }
            
        }
    }
}