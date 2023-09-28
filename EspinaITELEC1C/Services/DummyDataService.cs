using EspinaITELEC1C.Models;
using EspinaITELEC1C.Services;
namespace EspinaITELEC1C.Services
{
    //Java & PHP - Extends; C# - ':'
    public class DummyDataService : IDummyDataService
    {
        public List<StudentModel> StudentList { get; }
        public List<InstructorModel> InstructorsList { get; }

        public DummyDataService(){ 
            //Constructor Class
            StudentList = new List<StudentModel>() {
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

            InstructorsList = new List<InstructorModel>() {
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

        }

    }
}
