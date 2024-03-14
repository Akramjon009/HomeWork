using System.ComponentModel.DataAnnotations;

namespace User.Application.Entity.DTOs
{
    public class UserDTO
    {
        public string name { get; set; }
        public int age { get; set; }

        [EmailAddress]
        public string? email { get; set; }
    }
}
