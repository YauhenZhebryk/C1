namespace FunWithUnitTesting
{
    public class UserRepoFakeFree : IUserRepo
    {
        public string AddUserToDb(UserService.User user)
        {
            return "err";
        }

        public UserService.User GetUserFromDbByEmail(string email)
        {
            return null;
        }
    }
}
