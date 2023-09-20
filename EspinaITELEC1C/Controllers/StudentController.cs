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
                    GeneralWeightedAverage = 1.25,
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSIT,
                    StudentEmail = "allain.espina.cics@ust.edu.ph"
                },
                new StudentModel
                {
                    StudentId = 2,
                    StudentName = "Daniel Espina",
                    GeneralWeightedAverage = 1.5,
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSCS,
                    StudentEmail = "daniel.espina.cics@ust.edu.ph"
                },
                new StudentModel
                {
                    StudentId = 3,
                    StudentName = "Sanoy Espina",
                    GeneralWeightedAverage = 1.75,
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

        public IActionResult StudentDetails(int id)
        {

            StudentModel? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            StudentModel? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(StudentModel StudentChanges)
        {
            StudentModel? student = StudentList.FirstOrDefault(st => st.StudentId == StudentChanges.StudentId);

            if (StudentChanges != null)
            {
                student.StudentName = StudentChanges.StudentName;
                student.DateEnrolled = StudentChanges.DateEnrolled;
                student.StudentCourse = StudentChanges.StudentCourse;
                student.StudentEmail = StudentChanges.StudentEmail;

            }
            return View("Index", StudentList);
        }

    }
}
