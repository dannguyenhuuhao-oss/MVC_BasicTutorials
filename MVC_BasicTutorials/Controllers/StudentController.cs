
using System.Collections.Generic;
using System.Web.Mvc;
using MVC_BasicTutorials.Models;

namespace MVC_BasicTutorials.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    StudentId = 1,
                    StudentName = "John",
                    Age = 18
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Steve",
                    Age = 21
                },
                new Student
                {
                    StudentId = 3,
                    StudentName = "Bill",
                    Age = 25
                },
                new Student
                {
                    StudentId = 4,
                    StudentName = "Ram",
                    Age = 20
                },
                new Student
                {
                    StudentId = 5,
                    StudentName = "Ron",
                    Age = 31
                },
                new Student
                {
                    StudentId = 6,
                    StudentName = "Chris",
                    Age = 17
                },
                new Student
                {
                    StudentId = 7,
                    StudentName = "Rob",
                    Age = 19
                }
            };

            return View(students);
        }
    }
}
