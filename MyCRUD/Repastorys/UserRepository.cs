using Microsoft.EntityFrameworkCore;
using MyCRUD.Data;
using MyCRUD.Interface;
using MyCRUD.Models.cs;

namespace MyCRUD.Repastorys;
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _appDbContext;
    public UserRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;
    public async Task<User> CreateUser(User user)
    {
        User user1 = new User();
        user1.name = user.name;
        user1.email = user.email;
        user1.password = user.password;
        _appDbContext.users.Add(user1);
        await _appDbContext.SaveChangesAsync();  
        return  user1;
    }

    public async Task<User> DeleteUser(int id)
    {
        var user = await _appDbContext.users.FindAsync(id);
        _appDbContext.users.Remove(user);
        await _appDbContext.SaveChangesAsync();
        return user;

    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _appDbContext.users.ToListAsync();
        return users;

    }

    public async Task<User> Getgmail(int id)
    {
        var gmail = await _appDbContext.users.FindAsync(id);
        return gmail;
    }

    public async Task<User> GetById(int id)
    {
        var user = await _appDbContext.users.FindAsync(id);
        return user;

    }

    public async Task<User> UpdateUser(int id, User user)
    {
        var finduser = await _appDbContext.users.FindAsync(id);
        finduser.name = user.name;
        finduser.email = user.email;
        finduser.password = user.password;
        _appDbContext.users.Update(finduser);
        await _appDbContext.SaveChangesAsync();
        return user;
    }
}
