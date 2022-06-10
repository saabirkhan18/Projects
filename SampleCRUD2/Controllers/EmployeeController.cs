using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCRUD2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SampleCRUD2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _db;
        public EmployeeController(EmployeeDBContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            List<Employee> employees = (from m1 in _db.Employee
                                        join m2 in _db.Country on m1.CountryId equals m2.CountryId
                                        select new Employee
                                        {
                                            EmployeeId = m1.EmployeeId,
                                            Country_name = m2.Country_name,
                                            Email = m1.Email,
                                            Full_name = m1.Full_name,
                                            Mobile = m1.Mobile
                                        }
                                      ).OrderBy(t => t.Full_name).ToList();
            return View(employees);
        }

        private List<Country> GetCountries()
        {
            List<Country> countries = _db.Country.OrderBy(t => t.Country_name).ToList();
            countries.Insert(0, new Country() { CountryId = 0, Country_name = "--- Select ---" });
            return countries;
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            ViewBag.Countries = GetCountries();
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult CreateAndUpdate(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeId == 0)
                {
                    _db.Employee.Add(employee);
                    _db.SaveChanges();
                }
                else
                {
                    _db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Oop's something went wrong!. Try again");
                ViewBag.Countries = GetCountries();
                return View(employee);
            }

        }

        [HttpGet]
        public IActionResult Edit(Int64 EmployeeId)
        {
            ViewBag.Countries = GetCountries();
            var employee = _db.Employee.Where(t => t.EmployeeId == EmployeeId).FirstOrDefault();
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(Int64 EmployeeId)
        {
            _db.Employee.Remove(_db.Employee.Where(t => t.EmployeeId == EmployeeId).FirstOrDefault());
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult GetStates(int country_id)
        {
            var States = _db.States.Where(t => t.CountryId == country_id).ToList();
            return Json(new SelectList(States, "StateId", "StateName"));
        }
    }
}
