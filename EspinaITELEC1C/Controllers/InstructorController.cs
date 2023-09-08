using Microsoft.AspNetCore.Mvc;
using EspinaITELEC1C.Models;
using System.ComponentModel;

namespace EspinaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<InstructorModel> InstructorsList = new List<InstructorModel>() {
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
                };
        public IActionResult Index()
        {
            return View(InstructorsList);
        }

        public ActionResult ShowDetails(int id) 
        { 
            InstructorModel? instructor = InstructorsList.FirstOrDefault(ins => ins.Id == id);
           
            if(instructor != null)
                return View(instructor);

            return View(); 
        }
    }
}
