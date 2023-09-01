namespace TraineeProgram.Domain.Dto
{
    public class OfferLetterDto
    {
        public string Contract { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public int IdUser { get; set; }
        public int IdCandidate { get; set; }
        public int IdJobOpening { get; set; }
    }
    public class OfferLetterReadDto
    {
        public int IdOfferLetter { get; set; }
        public string Contract { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public int IdUser { get; set; }
        public int IdCandidate { get; set; }
        public int IdJobOpening { get; set; }
    }
}