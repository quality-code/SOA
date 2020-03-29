using Quality.JWT.Models;
using Quality.JWT.Models.DataBase;
using System.Linq;

namespace Quality.JWT.Services
{
    public class UserService : IUserService
    {
        private readonly QualityDbContext _ctx;
        public UserService(QualityDbContext ctx)
        {
            _ctx = ctx;
        }
        public bool IsValidUser(UserModel user)
        {
            return _ctx.Users.Any(x =>
                x.Username.ToLower().Equals(user.Username.ToLower()) &&
                x.Password.Equals(user.Password));
        }
    }
}
