namespace TraineeProgram.Domain.Dto
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginReadDto
    {
        public string UserName { get; set; }
    }
}