using MiniApiJWT.Models;

namespace MiniApiJWT.InterfaceServices
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
