
using System;
using System.Web.Mvc;
using MVC_BasicTutorials.Models;

namespace MVC_BasicTutorials.Controllers
{
    public class RazorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            Student student = new Student()
            {
                StudentId = 1,
                StudentName = "John",
                Age = 18
            };

            return View(student);
        }
    }
}
