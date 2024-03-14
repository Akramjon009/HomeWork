using User.Application.Entity.DTOs;
using User.Application.Entity.Model;


namespace OrderManagementAPI.Application.Abstractions.IService
{
    public interface IUserService
    {
        public Task<UserModel> CreateUser(UserDTO userDTO);
        public Task<UserModel> GetUserById(int Id);
        public Task<IEnumerable<UserModel>> GetAllUser();
        public Task<UserModel> UpdateUser(int Id,UserDTO userDTO);
        public Task<bool> DeleteUser(int id);
    }
}
