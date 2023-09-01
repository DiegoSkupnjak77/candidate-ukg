using Microsoft.AspNetCore.Http;

namespace TraineeProgram.Domain.Dto
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int UserRole { get; set; }
        public string Password { get; set; }
        public IFormFile Photo { get; set; }
    }

    public class UserReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int UserRole { get; set; }
        public byte[] Photo { get; set; }
    }
}