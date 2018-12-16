using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flixly.Models;

namespace Flixly.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers = new List<Customer>()
        {
            new Customer() { Id = 1, Name = "Ram"},
            new Customer() { Id = 2, Name = "Lakshmana"}
        };

        // GET: Customer
        public ActionResult Index()
        {
            return View(_customers);
        }

        [Route("customer/details/{id:regex(\\d{1})}")]
        public ActionResult Edit(int id)
        {
            Customer customer = (Customer)_customers.SingleOrDefault(c => c.Id == id);
            if (customer != null)
                return View("EditCustomer", customer);
            else
                return HttpNotFound();

        }

    }
}