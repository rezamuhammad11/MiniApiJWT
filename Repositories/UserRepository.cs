using MiniApiJWT.Models;

namespace MiniApiJWT.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new()
            {
                UserName = "admin",
                EmailAddress = "admin@gmail.com",
                Password = "P@ssw0rd",
                GivenName = "Admin",
                SurName = "Admin",
                Role = "Administrator"
            },
            new()
            {
                UserName = "user1",
                EmailAddress = "user1@gmail.com",
                Password = "P@ssw0rd",
                GivenName = "User1",
                SurName = "User1",
                Role = "User"
            },
        };
    }
}
