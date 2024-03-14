using Microsoft.EntityFrameworkCore;
using User.Application.Entity.Model;

namespace User.Infrostracture.Persistace
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> option)
            : base(option)
        {

        }
        public virtual DbSet<UserModel> Users { get; set; }

    }
}
