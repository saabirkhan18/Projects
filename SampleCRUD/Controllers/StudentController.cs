using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCRUD.Models;
namespace SampleCRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _db;
        public StudentController(StudentContext db)
        {
            this._db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = (from m1 in _db.tbl_Student
                          join m2 in _db.tbl_Department on m1.DepartmentId equals m2.DepartmentId
                          select new Student
                          {
                              StudentId = m1.StudentId,
                              DepartmentId = m1.DepartmentId,
                              FullName = m1.FullName,
                              Mobile = m1.Mobile,
                              Department = m2.DepartmentName,
                              Email = m1.Email
                          }
                        ).ToList();
            return View(result);
        }
        private List<Department> GetDepartment()
        {
            List<Department> DeptList = _db.tbl_Department.ToList();
            DeptList.Insert(0, new Department() { DepartmentId = 0, DepartmentName = "Select department" });
            return DeptList;
        }
        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.DepartmentList = GetDepartment();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            Student Obj = _db.tbl_Student.Where(t => t.StudentId == id).FirstOrDefault();
            ViewBag.DepartmentList = GetDepartment();
            return View(Obj);
        }


        [HttpPost]
        public IActionResult AddUpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)
                {
                    _db.tbl_Student.Add(student);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    _db.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            else
            {
                ModelState.AddModelError("", "Oop's something went wrong");
                ViewBag.DepartmentList = GetDepartment();
                return View("Create", student);
            }
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            Student Obj = _db.tbl_Student.Where(t => t.StudentId == id).FirstOrDefault();
            if (Obj != null)
            {
                _db.tbl_Student.Remove(Obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
