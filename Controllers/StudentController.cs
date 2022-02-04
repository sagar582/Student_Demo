using Student_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Student_Demo.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "Sagar", Age = 22 } ,
                new Student() { StudentId = 2, StudentName = "Ayush",  Age = 22 } ,
                new Student() { StudentId = 3, StudentName = "Priya",  Age = 22 }
            };


        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult HtmlHelp()
        {
            return View();
        }

        public ActionResult StudentLogin()
        {
            return View();
        }

        public ActionResult Validation(Student std)
        {
            return View(std);
        }

        public ActionResult LayoutExample()
        {
            return View("LayoutExample","_myLayoutPage");
        }
        public ActionResult LayoutExample2()
        {
            return View("LayoutExample2", "_myLayoutPage");
        }
    }
}