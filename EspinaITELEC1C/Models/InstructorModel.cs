namespace EspinaITELEC1C.Models
{
    public enum Ranks
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class InstructorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean IsTenured { get; set; }
        public Ranks Rank { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
