namespace TraineeProgram.Domain.Dto
{
    public class CandidateDto
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string? Photo { get; set; }
        public string? CoverLetter { get; set; }
        public string? UploadResume { get; set; }
        public bool IsActive { get; set; }
        public int IdJobOpening { get; set; }
        public List<CandidatelinkDto> Candidatelinks { get; set; }
    }
    public class CandidateReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string? Photo { get; set; }
        public string? CoverLetter { get; set; }
        public string? UploadResume { get; set; }
        public bool IsActive { get; set; }
        public int IdJobOpening { get; set; }
        public List<CandidatelinkDto> Candidatelinks { get; set; }
    }

    public class CandidatelinkDto
    {
        public string Link { get; set; }
    }

    public class CandidateHomeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Deparment { get; set; }
        public string StepOfProcess { get; set; }
        public bool Status { get; set; }
    }
}