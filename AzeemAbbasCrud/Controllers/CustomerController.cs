using AzeemAbbasCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace AzeemAbbasCrud.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext DbContext)
        {

            this.DbContext = DbContext;
        }

        public IActionResult Index()
        {
            List<Location> locations = DbContext.Locations.ToList();
            return View(locations);
        }

        public IActionResult CustomerList(int id)
        {
            List<Customer> Customers = DbContext.Customers.Where(e => e.Location.id == id).ToList();
            return View(Customers);

        }

    }
}
