using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;
using System.ComponentModel;
using EspinaITELEC1C.Services;

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

        private readonly IDummyDataService _dummyData;

        public InstructorController(IDummyDataService dummyData) //Constructor
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {
            //return View(_dummyData.InstructorsList);
            return View("Index", _dummyData.InstructorsList);
        }

        public ActionResult ShowDetails(int id) 
        { 
            //Search for the student that matches the given id
            InstructorModel? instructor = _dummyData.InstructorsList.FirstOrDefault(ins => ins.Id == id);
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
            _dummyData.InstructorsList.Add(newInstructor);
            return View("Index", _dummyData.InstructorsList);
        }
        
        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            InstructorModel? instructor = _dummyData.InstructorsList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(InstructorModel InstructorChanges)
        {
            InstructorModel? instructor = _dummyData.InstructorsList.FirstOrDefault(ins => ins.Id == InstructorChanges.Id);

            if (InstructorChanges != null)
            {
                instructor.FirstName = InstructorChanges.FirstName;
                instructor.LastName = InstructorChanges.LastName;
                instructor.IsTenured = InstructorChanges.IsTenured;
                instructor.Rank = InstructorChanges.Rank;
                instructor.HiringDate = InstructorChanges.HiringDate;

            }
            return View("Index", _dummyData.InstructorsList);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            InstructorModel? instructor = _dummyData.InstructorsList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(InstructorModel newInstructor)
        {
            InstructorModel? instructor = _dummyData.InstructorsList.FirstOrDefault(ins => ins.Id == newInstructor.Id);

            if (instructor != null)
                _dummyData.InstructorsList.Remove(instructor);

            return View("Index", _dummyData.InstructorsList);
        }

    }
}
