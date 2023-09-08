using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;

namespace EspinaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {

            StudentModel student = new StudentModel();

            student.StudentId = 2021160384;
            student.StudentName = "Espina, Allain Daniel S.";
            student.DateEnrolled = DateTime.Parse("30/08/2023");
            student.StudentCourse = Course.BSIT;
            student.StudentEmail = "allaindaniel.espina.cics@ust.edu.ph";

            ViewBag.StudentId = student.StudentId;
            ViewBag.StudentName = student.StudentName;
            ViewBag.DateEnrolled = student.DateEnrolled;
            ViewBag.StudentCourse = student.StudentCourse;
            ViewBag.StudentEmail = student.StudentEmail;

            return View();

        }
    }
}
