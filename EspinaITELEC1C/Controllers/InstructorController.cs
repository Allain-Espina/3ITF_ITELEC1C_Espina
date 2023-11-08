using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;
using System.ComponentModel;
using EspinaITELEC1C.Services;
using EspinaITELEC1C.Data;

namespace EspinaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        /*List<InstructorModel> InstructorsList = new List<InstructorModel>() {
                    new InstructorModel(){
                        Id = 1,
                        FirstName = "Allain",
                        LastName = "Espina",
                        IsTenured = true,
                        Rank = Ranks.AssociateProfessor,
                        HiringDate = DateTime.Parse("06/1/2023").Date
                      },

                    new InstructorModel(){
                        Id = 2,
                        FirstName = "Allen",
                        LastName = "De Juan",
                        IsTenured = true,
                        Rank = Ranks.Professor,
                        HiringDate = DateTime.Parse("07/2/2023").Date
                      },

                    new InstructorModel(){
                        Id = 3,
                        FirstName = "Aira",
                        LastName = "Cruz",
                        IsTenured = false,
                        Rank = Ranks.AssistantProfessor,
                        HiringDate = DateTime.Parse("08/3/2023").Date
                      },
                    new InstructorModel(){
                        Id = 4,
                        FirstName = "Jesmith",
                        LastName = "Simbulan",
                        IsTenured = false,
                        Rank = Ranks.Instructor,
                        HiringDate = DateTime.Parse("09/4/2023").Date
                      },
                };*/

        /*private readonly IDummyDataService _dummyData;

        public InstructorController(IDummyDataService dummyData) //Constructor
        {
            _dummyData = dummyData;
        }*/

        private readonly AppDbContext _dbData;

        public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        public IActionResult Index()
        {
            //return View(_dummyData.InstructorsList);
            return View("Index", _dbData.Instructors);
        }

        public ActionResult ShowDetails(int id) 
        { 
            //Search for the student that matches the given id
            InstructorModel? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);
            //FirstOrDefault = Checks who is the first on the list
            if(instructor != null)
                return View(instructor);

            return NotFound(); 
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(InstructorModel newInstructor)
        {
            if (!ModelState.IsValid)
                return View();

            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return View("Index", _dbData.Instructors);
        }
        
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            InstructorModel? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(InstructorModel InstructorChanges)
        {
            InstructorModel? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == InstructorChanges.Id);

            if (InstructorChanges != null)
            {
                instructor.FirstName = InstructorChanges.FirstName;
                instructor.LastName = InstructorChanges.LastName;
                instructor.IsTenured = InstructorChanges.IsTenured;
                instructor.Rank = InstructorChanges.Rank;
                instructor.HiringDate = InstructorChanges.HiringDate;
                _dbData.SaveChanges();

            }
            return View("Index", _dbData.Instructors);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            InstructorModel? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(InstructorModel newInstructor)
        {
            InstructorModel? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == newInstructor.Id);

            if (instructor != null)
                _dbData.Instructors.Remove(instructor);
                _dbData.SaveChanges();


            return View("Index", _dbData.Instructors);
        }

    }
}
