using EspinaITELEC1C.Models;
namespace EspinaITELEC1C.Services
{

    public interface IDummyDataService
    {
        List<StudentModel> StudentList { get;}
        List<InstructorModel> InstructorsList { get;}
    }
}
