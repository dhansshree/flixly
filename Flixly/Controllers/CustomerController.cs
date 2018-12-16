using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flixly.Models;
using System.Data.Entity;

namespace Flixly.Controllers
{
    public class CustomerController : Controller
    {
        private FlixlyDbContext _context;

        public CustomerController()
        {
            _context = new FlixlyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(_context.customers.Include(c => c.MembershipType).ToList());
        }

        [Route("customer/details/{id:regex(\\d{1})}")]
        public ActionResult Edit(int id)
        {
            Customer customer = _context.customers.SingleOrDefault(c => c.Id == id);
            if (customer != null)
                return View("EditCustomer", customer);
            else
                return HttpNotFound();

        }

    }
}