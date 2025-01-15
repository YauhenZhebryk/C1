using static FunWithUnitTesting.UserService;

namespace FunWithUnitTesting
{
    public class UserRepoFakeRegistredEmail : IUserRepo
    {
        public string AddUserToDb(UserService.User user)
        {
            return string.Empty;
        }

        public UserService.User GetUserFromDbByEmail(string email)
        {
            return new User();
        }
    }
}
