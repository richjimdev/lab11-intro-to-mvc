using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            // Looks for the Razor View Page located in
            // Views -> Home -> Index.cshtml
            return View();
        }
        /// <summary>
        /// Post action for form submission of student information
        /// </summary>
        /// <param name="studentName">name of student</param>
        /// <param name="studentAge">Age of Student</param>
        /// <returns>Redirect to the Results of student information</returns>
        //[HttpPost]
        //public IActionResult Index(string studentName, int studentAge)
        //{
        //    // Redirect to another Action. 
        //    // we create a 
        //    return RedirectToAction("Result", new { studentName, studentAge });
        //}

        /// <summary>
        /// Output the results of the Student Information
        /// </summary>
        /// <param name="studentName">name of student</param>
        /// <param name="studentAge">Age of student</param>
        /// <returns>Generated View of Result Action</returns>
        //public ViewResult Result(string studentName, int studentAge)
        //{
        //    Student student = new Student();
        //    student.Name = studentName;
        //    student.Age = studentAge;
        //    return View(student);
        //}

        //public ViewResult Class()
        //{
        //    Student student = new Student();
        //    student.Name = "Nancy";
        //    student.Age = 18;

        //    Student s1 = new Student();
        //    s1.Name = "Amanda";
        //    s1.Age = 50;

        //    Student s2 = new Student();
        //    s2.Name = "Molly";
        //    s2.Age = 18;

        //    Student s3 = new Student();
        //    s3.Name = "Jeff";
        //    s3.Age = 22;

        //    List<Student> myStudents = new List<Student> { student, s1, s2, s3 };


        //    return View(myStudents);
        //}
    }
}
