namespace TraineeProgram.Domain.Dto
{
    public class JobOpeningDto
    {
        public string Position { get; set; } = string.Empty;
        public int OpenPositions { get; set; } = 1;
        public string Department { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string JobSummary { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }

    public class JobOpeningReadDto
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