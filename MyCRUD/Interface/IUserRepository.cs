using MyCRUD.Models.cs;

namespace MyCRUD.Interface;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers();
    Task<User> GetById(int id);
    Task<User> Getgmail(int  id);
    Task<User> CreateUser(User user);
    Task<User> UpdateUser(int id,User user);
    Task<User> DeleteUser(int id);

}
