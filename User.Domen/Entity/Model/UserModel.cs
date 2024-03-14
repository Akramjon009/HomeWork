using System.ComponentModel.DataAnnotations;

namespace User.Application.Entity.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        [EmailAddress]
        public string? email { get; set; }

    }
}
