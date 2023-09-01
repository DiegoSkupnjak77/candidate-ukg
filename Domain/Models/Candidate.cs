namespace TraineeProgram.Domain.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string  MobilePhone { get; set; }
        public string Email { get; set; }
        public string? Photo { get; set; }
        public string? CoverLetter { get; set; }
        public string? UploadResume { get; set; }
        public bool IsActive { get; set; }
        public int IdJobOpening { get; set; }
        public List<Candidatelink> Candidatelinks { get; set; }
    }
    public class Candidatelink
    {
        public string Link { get; set; }
    }
}