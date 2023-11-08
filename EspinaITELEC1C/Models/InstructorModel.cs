using System.ComponentModel.DataAnnotations;

namespace EspinaITELEC1C.Models
{
    public enum Ranks
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class InstructorModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Type in your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Type in your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "State your Status")]
        [Display(Name = "Instructor Status")]
        public Boolean IsTenured { get; set; }

        [Required(ErrorMessage = "State your Rank")]
        [Display(Name = "Instructor Position")]
        public Ranks Rank { get; set; }

        [Required(ErrorMessage = "Please provide your hiring date")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Hired")]
        public DateTime HiringDate { get; set; }

        [Required(ErrorMessage = "Type in your Email Address")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Type in your Phone Number")]
        [RegularExpression("[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "Follow the Format: XX-XXX-XXXX")]
        [Display(Name = "Phone Number")]
        public string Phone {  get; set; }
    }
}
