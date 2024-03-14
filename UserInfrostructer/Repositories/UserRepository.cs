using OrderManagementAPI.Application.Abstractions.IRepositories;
using User.Application.Entity.Model;
using User.Infrostracture.Persistace;

namespace OrderManagementAPI.Infrostracture.Repositories
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {
        }
    }
}
