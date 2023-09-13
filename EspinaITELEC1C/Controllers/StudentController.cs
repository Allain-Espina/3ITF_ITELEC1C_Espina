using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;

namespace EspinaITELEC1C.Controllers
{
    public class StudentController : Controller
    {

        List<StudentModel> StudentList = new List<StudentModel>() {

        new StudentModel
                {
                    StudentId = 1,
                    StudentName = "Allain Espina",
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSIT,
                    StudentEmail = "allain.espina.cics@ust.edu.ph"
                },
                new StudentModel
                {
                    StudentId = 2,
                    StudentName = "Daniel Espina",
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSCS,
                    StudentEmail = "daniel.espina.cics@ust.edu.ph"
                },
                new StudentModel
                {
                    StudentId = 3,
                    StudentName = "Sanoy Espina",
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSIS,
                    StudentEmail = "sanoy.espina.cics@ust.edu.ph"
                }
        };

        public IActionResult Index()
        {

            //StudentModel student = new StudentModel();

            //student.StudentId = 2021160384;
            //student.StudentName = "Espina, Allain Daniel S.";
            //student.DateEnrolled = DateTime.Parse("30/08/2023");
            //student.StudentCourse = Course.BSIT;
            //student.StudentEmail = "allaindaniel.espina.cics@ust.edu.ph";

            //ViewBag.StudentId = student.StudentId;
            //ViewBag.StudentName = student.StudentName;
            //ViewBag.DateEnrolled = student.DateEnrolled;
            //ViewBag.StudentCourse = student.StudentCourse;
            //ViewBag.StudentEmail = student.StudentEmail;

            return View(StudentList);

        }

        public ActionResult StudentDetails(int id)
        {

            StudentModel? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

    }
}
