using System.ComponentModel.DataAnnotations;

namespace EspinaITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }

    public class StudentModel
    {
        [Key] 
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public Course StudentCourse { get; set; }
        public string StudentEmail { get; set; }
        public double GeneralWeightedAverage { get; set; }

    }
}
