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
            var customers = GetCustomer();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer { Id = 2, Name = "Mary Williams"},
                new Customer { Id = 3, Name = "Jesse Pinkman"},
                new Customer { Id = 4, Name = "Koshila Sandaru"},
                new Customer { Id = 5, Name = "Mark Zucker"}
            };
        }

        
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);
            
            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);

        }
    }
}