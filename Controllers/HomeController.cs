using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Submit_form.Models;

namespace Submit_form.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult /*ViewResult*/ Index()
        {
            //ViewBag.createview = "su dung viewbag";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Register( Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("myview");
            }
            else
            {
                return View();
            }
        }

        public IActionResult StudentList()
        {
            return View(Repository.GetStudents());
        }
    }
}
