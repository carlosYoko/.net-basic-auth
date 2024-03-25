using WebApplication1.Models;

namespace WebApplication1.Security;

public class UserService : IUserService
{
    private readonly List<User> users = new()
    {
        new User { Email = "carlos@hotmail.com", Password = "12345" },
        new User { Email = "mosca@hotmail.com", Password = "12345" }
    };

    public bool IsUser(string email, string pass)
    {
        return users.Where(u => u.Email == email && u.Password == pass).Count() > 0;
    }
}