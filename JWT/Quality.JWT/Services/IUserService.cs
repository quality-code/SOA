using Quality.JWT.Models;

namespace Quality.JWT.Services
{
    public interface IUserService
    {
        bool IsValidUser(UserModel user);
    }
}