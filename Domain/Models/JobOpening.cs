namespace TraineeProgram.Domain.Models
{
    public class JobOpening
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public int OpenPositions { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string JobSummary { get; set; }
        public string Link { get; set; }
    }
}