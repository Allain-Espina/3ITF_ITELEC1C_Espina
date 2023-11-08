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

        [Required(ErrorMessage = "Please type in your name")]
        [Display(Name = "Student's Name")]
        public string? StudentName { get; set; }

        
        [Display(Name = "General Weighted Average")]
        [Required(ErrorMessage = "Please provide your GWA")]
        public double GeneralWeightedAverage { get; set; }

        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Please indicate your Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime DateEnrolled { get; set; }

        [Display(Name = "Course")]
        public Course StudentCourse { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please provide your Email Address")]
        [EmailAddress]
        public string? StudentEmail { get; set; }

    }
}
