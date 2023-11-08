using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;
//using EspinaITELEC1C.Services;
using EspinaITELEC1C.Data;


namespace EspinaITELEC1C.Controllers
{
    public class StudentController : Controller
    {

        /*List<StudentModel> StudentList = new List<StudentModel>() {

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
        };*/

        /*private readonly IDummyDataService _dummyData;

        public StudentController(IDummyDataService dummyData) //Constructor
        {
            _dummyData = dummyData;
        }*/

        private readonly AppDbContext _dbData;

        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

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

            return View(_dbData.Students);

        }

        public IActionResult StudentDetails(int id)
        {

            StudentModel? student = _dbData.Students.FirstOrDefault(st => st.StudentId == id);

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
            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            //return View("Index", _dummyData.StudentList);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            StudentModel? student = _dbData.Students.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(StudentModel StudentChanges)
        {
            StudentModel? student = _dbData.Students.FirstOrDefault(st => st.StudentId == StudentChanges.StudentId);

            if (StudentChanges != null)
            {
                student.StudentName = StudentChanges.StudentName;
                student.GeneralWeightedAverage = StudentChanges.GeneralWeightedAverage;
                student.DateEnrolled = StudentChanges.DateEnrolled;
                student.StudentCourse = StudentChanges.StudentCourse;
                student.StudentEmail = StudentChanges.StudentEmail;
                _dbData.SaveChanges();
            }
            return View("Index", _dbData.Students);
            //return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            StudentModel? student = _dbData.Students.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(StudentModel newStudent)
        {
            StudentModel? student = _dbData.Students.FirstOrDefault(st => st.StudentId == newStudent.StudentId);

            if (student != null)
                _dbData.Students.Remove(student);
                _dbData.SaveChanges();


            return View("Index", _dbData.Students);
        }

    }
}
