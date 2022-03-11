using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzeemAbbasCrud.Models;

namespace AzeemAbbasCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public  EmployeeController(ApplicationDbContext dbContex)
        {
            this.dbContext = dbContex;
       }
        public IActionResult Index()
        {
            List<Employee> emps = dbContext.Employees.ToList();
            return View(emps);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            { 
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("index");
            }
            else
            {
                return View (emp);
            }
        }

        public IActionResult Delete(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.id == id);
            if(emp != null)
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }        
            else
            {
                return RedirectToAction("Index");
            }

        }
        public IActionResult Edit(int  id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.id == id);
            
                return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            dbContext.Employees.Update(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
