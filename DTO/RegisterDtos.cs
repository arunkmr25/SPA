using System;

namespace connections.DTO
{
    public class RegisterDtos
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string KnownAs { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }  

        public RegisterDtos()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

        
    }
}